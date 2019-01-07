namespace DataModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_Tables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        InternalToken = c.Guid(nullable: false),
                        Username = c.String(nullable: false),
                        PasswordHash = c.String(nullable: false),
                        PhoneNumber = c.String(nullable: false, maxLength: 20),
                        Firstname = c.String(),
                        Lastname = c.String(),
                        Pesel = c.String(),
                        VacationDays = c.Int(nullable: false),
                        Roles = c.String(),
                        Company_Id = c.Guid(),
                        X_CreatedDate = c.DateTime(),
                        X_LastUpdateDate = c.DateTime(),
                        X_ArchivedDate = c.DateTime(),
                        X_Archived = c.Boolean(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Companies", t => t.Company_Id)
                .Index(t => t.InternalToken, unique: true, name: "IX_UserInternalToken")
                .Index(t => t.Company_Id);
            
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        PostalCode = c.String(),
                        City = c.String(),
                        Street = c.String(),
                        Polity = c.String(),
                        User_Id = c.Guid(),
                        Company_Id = c.Guid(),
                        X_CreatedDate = c.DateTime(),
                        X_LastUpdateDate = c.DateTime(),
                        X_ArchivedDate = c.DateTime(),
                        X_Archived = c.Boolean(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Companies", t => t.Company_Id)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .Index(t => t.User_Id)
                .Index(t => t.Company_Id);
            
            CreateTable(
                "dbo.Companies",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        ShortName = c.String(),
                        FullName = c.String(),
                        TaxpayerIdentyficationNumber = c.String(),
                        Regon = c.String(),
                        X_CreatedDate = c.DateTime(),
                        X_LastUpdateDate = c.DateTime(),
                        X_ArchivedDate = c.DateTime(),
                        X_Archived = c.Boolean(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Conclusions",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        VacationType = c.String(),
                        Accepted = c.Boolean(nullable: false),
                        AcceptedDate = c.DateTime(nullable: false),
                        User_Id = c.Guid(),
                        X_CreatedDate = c.DateTime(),
                        X_LastUpdateDate = c.DateTime(),
                        X_ArchivedDate = c.DateTime(),
                        X_Archived = c.Boolean(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .Index(t => t.User_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Conclusions", "User_Id", "dbo.Users");
            DropForeignKey("dbo.Addresses", "User_Id", "dbo.Users");
            DropForeignKey("dbo.Users", "Company_Id", "dbo.Companies");
            DropForeignKey("dbo.Addresses", "Company_Id", "dbo.Companies");
            DropIndex("dbo.Conclusions", new[] { "User_Id" });
            DropIndex("dbo.Addresses", new[] { "Company_Id" });
            DropIndex("dbo.Addresses", new[] { "User_Id" });
            DropIndex("dbo.Users", new[] { "Company_Id" });
            DropIndex("dbo.Users", "IX_UserInternalToken");
            DropTable("dbo.Conclusions");
            DropTable("dbo.Companies");
            DropTable("dbo.Addresses");
            DropTable("dbo.Users");
        }
    }
}
