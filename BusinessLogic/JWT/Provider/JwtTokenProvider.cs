using Common.Configuration;
using DataModel.Entities;
using DataModel.Repository.Interfaces;
using Microsoft.IdentityModel.Tokens;
using SREWT.JWT.Provider.Interfaces;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.IO;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using SREWT.Models;
using Common.Results;

namespace SREWT.JWT.Provider
{
    public class JwtTokenProvider : IJwtTokenProvider
    {
        public string Name
        {
            get
            {
                return "JwtTokenProvider";
            }
        }

        private static SigningCredentials _signingCredentials;
        private static SecurityKey _securityKey;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMembershipHashProvider _membershipHashProvider;

        public JwtTokenProvider(IUnitOfWork unitOfWork, IMembershipHashProvider membershipHashProvider)
        {
            _unitOfWork = unitOfWork;
            _membershipHashProvider = membershipHashProvider;


            string signingKeyPath = HttpRuntime.AppDomainAppPath + "App_Data\\rsakey.dat";
            string signingKey = null;

            if (File.Exists(signingKeyPath))
            {
                signingKey = File.ReadAllText(signingKeyPath);
            }
            else
            {
                RSACryptoServiceProvider myRSA = new RSACryptoServiceProvider(2048);
                RSAParameters publicKey = myRSA.ExportParameters(true);
                signingKey = myRSA.ToXmlString(true);

                using (StreamWriter streamWriter = File.CreateText(signingKeyPath))
                {
                    streamWriter.Write(signingKey);
                }
            }

            _securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(signingKey));
            _signingCredentials = new Microsoft.IdentityModel.Tokens.SigningCredentials(_securityKey, SecurityAlgorithms.HmacSha256);
        }

        public async Task<ServiceResult<string>> GenerateToken(string username, string password)
        {
            ServiceResult<string> result = new ServiceResult<string>(null);
            if (await this.VerifyUserPassword(username, password))
            {
                byte[] byteArray = Encoding.ASCII.GetBytes(JwtRegisteredClaimNames.UniqueName);
                MemoryStream stream = new MemoryStream(byteArray);

                // Create the JWT
                var claimsIdentity = new ClaimsIdentity(new[]
                {
                    new Claim(JwtRegisteredClaimNames.UniqueName, username),
                    //new System.Security.Claims.Claim(new System.IO.BinaryReader(stream),new ClaimsIdentity(username)),
                    // And any other bit of (session) data you want....
                });

                DateTime now = DateTime.UtcNow;
                JwtSecurityTokenHandler tokenHandler = new JwtSecurityTokenHandler();

                Microsoft.IdentityModel.Tokens.SecurityTokenDescriptor tokenDescriptor = new Microsoft.IdentityModel.Tokens.SecurityTokenDescriptor
                {
                    Subject = claimsIdentity,
                    Issuer = SecurityConfiguration.TokenIssuer,
                    Audience = SecurityConfiguration.TokenAudience,
                    SigningCredentials = _signingCredentials,
                    IssuedAt = now,
                };

                int tokenLifetime = Int32.Parse(SecurityConfiguration.TokenLifetime);
                if (tokenLifetime > 0)
                {
                    tokenDescriptor.Expires = now.AddMinutes(tokenLifetime);
                }

                Microsoft.IdentityModel.Tokens.SecurityToken token = tokenHandler.CreateToken(tokenDescriptor);

                result.Result = tokenHandler.WriteToken(token);
                return result;
            }
            else
            {
                return result.AddError(this.Name, "GenerateToken", ServiceMessageType.Warning, "Incorrect password or user does not exist", null);
            }
        }

        public Task<ClaimsPrincipal> ValidateToken(string token)
        {
            return Task.Run(() =>
            {
                ClaimsPrincipal result = null;

                // Validate the JWT
                var validationParams = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidIssuer = SecurityConfiguration.TokenIssuer,

                    ValidateAudience = true,
                    ValidAudience = SecurityConfiguration.TokenAudience,

                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = _securityKey,

                    RequireExpirationTime = true,
                    ValidateLifetime = true
                };

                try
                {
                    var tokenHandler = new JwtSecurityTokenHandler();
                    //tokenHandler.InboundClaimTypeMap["name"] = ClaimTypes.Name;

                    SecurityToken securityToken;
                    result = tokenHandler.ValidateToken(token, validationParams, out securityToken);
                }
                catch (Exception)
                {
                    result = null;
                }

                return result;
            });
        }

        private async Task<bool> VerifyUserPassword(string username, string password)
        {
            IRepository<User> userRepository = this._unitOfWork.Repository<User>();
            User user = await userRepository.Select(u => u.Username == username);

            if (user != null)
            {
                return await _membershipHashProvider.VerifyPassword(password, user.PasswordHash);
            }
            else
            {
                return false;
            }
        }
    }
}
