namespace DataModel.Migrations
{
    using Common.Models;
    using DataModel.Entities;
    using System;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<DataModel.Container.DatabaseContainer>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DataModel.Container.DatabaseContainer context)
        {

            //#region #### User Address #####
            Guid addresId = Guid.NewGuid();
            string postalCode = "98-399";
            string city = "Warsaw";
            string street = "Kielczowska";
            string polity = "Poland";

            //#region #### User #####
            Guid userId = Guid.NewGuid();
            Guid internalToken = Guid.NewGuid();
            string username = "admin";
            string firstname = "Administrator";
            string passwordHash = "$MYHASH$V1$10000$vQrV28x+zr26fI5fTPxR813C2+6ZoZOtO6bfDwEbYtDglg2v";
            string phoneNumber = "123456789";

            //#region #### Company Address #####
            Guid companyAddresId = Guid.NewGuid();
            string companyPostalCode = "98-399";
            string companyCity = "Wroclaw";
            string companyStreet = "Komandorska";
            string compnyPolity = "Poland";

            //#region #### Company #####
            Guid companyId = Guid.NewGuid();
            string shortName = "Air Company";
            string fullName = "Air Comany inc.";
            string taxpayerIdentyficationNumber = "0123456789";
            string regon = "123456789";


            Address userAddress = new Address()
            {
                Id = addresId,
                PostalCode = postalCode,
                City = city,
                Street = street,
                Polity = polity,
                X_CreatedDate = DateTime.UtcNow,
                X_LastUpdateDate = DateTime.UtcNow
            };

            Address comapnyAddress = new Address()
            {
                Id = companyAddresId,
                PostalCode = companyPostalCode,
                City = companyCity,
                Street = companyStreet,
                Polity = compnyPolity,
                X_CreatedDate = DateTime.UtcNow,
                X_LastUpdateDate = DateTime.UtcNow
            };

            Company company = new Company()
            {
                Id = companyId,
                Address_Id = companyAddresId,
                ShortName = shortName,
                FullName = fullName,
                TaxpayerIdentyficationNumber = taxpayerIdentyficationNumber,
                Regon = regon,
                X_CreatedDate = DateTime.UtcNow,
                X_LastUpdateDate = DateTime.UtcNow
            };

            User user = new User()
            {
                Id = userId,
                InternalToken = internalToken,
                Username = username,
                Firstname = firstname,
                PasswordHash = passwordHash,
                PhoneNumber = phoneNumber,
                Roles = RoleType.Admin,
                Address_Id = addresId,
                Company_Id = companyId,
                X_CreatedDate = DateTime.UtcNow,
                X_LastUpdateDate = DateTime.UtcNow
            };

            context.Addresses.AddOrUpdate(x => x.Id, userAddress);
            context.Addresses.AddOrUpdate(x => x.Id, comapnyAddress);
            context.Companies.AddOrUpdate(x => x.Id, company);
            context.Users.AddOrUpdate(x => x.Id, user);
        }

    }
}
