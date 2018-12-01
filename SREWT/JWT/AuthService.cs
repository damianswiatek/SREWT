using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Threading.Tasks;
using Microsoft.IdentityModel.Tokens;

namespace SREWT.JWT
{
    public class AuthService : IAuthService
    {
        private readonly IMembershipProvider _membershipProvider;
        private readonly IRSAKeyProvider _rsaProvider;

        public AuthService(IMembershipProvider membershipProvider, IRSAKeyProvider rsaProvider)
        {
            _membershipProvider = membershipProvider;
            _rsaProvider = rsaProvider;
        }

        public async Task<string> GenerateJwtTokenAsync(string username, string password)
        {
            if (!_membershipProvider.VerifyUserPassword(username, password))
                return "Wrong access";

            List<Claim> claims = _membershipProvider.GetUserClaims(username);

            string publicAndPrivateKey = await _rsaProvider.GetPrivateAndPublicKeyAsync();
            if (publicAndPrivateKey == null)
                return "RSA key error";

            RSACryptoServiceProvider publicAndPrivate = new RSACryptoServiceProvider();
            publicAndPrivate.FromXmlString(publicAndPrivateKey);

            JwtSecurityToken jwtToken = new JwtSecurityToken
            (
                issuer: "http://issuer.com",
                audience: "http://mysite.com",
                claims: claims,
                signingCredentials: new SigningCredentials(new RsaSecurityKey(publicAndPrivate), SecurityAlgorithms.RsaSha256Signature),
                expires: DateTime.Now.AddDays(30)
            );

            JwtSecurityTokenHandler tokenHandler = new JwtSecurityTokenHandler();
            string tokenString = tokenHandler.WriteToken(jwtToken);

            return tokenString;
        }

        public async Task<Boolean> ValidateTokenAsync(string TokenString)
        {
            Boolean result = false;

            try
            {
                SecurityToken securityToken = new JwtSecurityToken(TokenString);
                JwtSecurityTokenHandler securityTokenHandler = new JwtSecurityTokenHandler();
                RSACryptoServiceProvider publicAndPrivate = new RSACryptoServiceProvider();

                string publicAndPrivateKey = await _rsaProvider.GetPrivateAndPublicKeyAsync();
                if (publicAndPrivateKey == null)
                    return result;

                publicAndPrivate.FromXmlString(publicAndPrivateKey);

                TokenValidationParameters validationParameters = new TokenValidationParameters()
                {
                    ValidIssuer = "http://issuer.com",
                    ValidAudience = "http://mysite.com",
                    IssuerSigningKey = new RsaSecurityKey(publicAndPrivate)
                };

                ClaimsPrincipal claimsPrincipal = securityTokenHandler.ValidateToken(TokenString, validationParameters, out securityToken);

                result = true;
            }
            catch (Exception)
            {
                result = false;
            }

            return result;
        }
    }
}