namespace DataModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUserTable : DbMigration
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
                        ReversedPhoneNumber = c.String(nullable: false, maxLength: 20),
                        Firstname = c.String(),
                        Lastname = c.String(),
                        PostalCode = c.String(),
                        City = c.String(),
                        Street = c.String(),
                        Roles = c.String(),
                        RegistrationDate = c.DateTime(nullable: false),
                        X_CreatedDate = c.DateTime(),
                        X_LastUpdateDate = c.DateTime(),
                        X_ArchivedDate = c.DateTime(),
                        X_Archived = c.Boolean(),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.InternalToken, unique: true, name: "IX_UserInternalToken")
                .Index(t => t.PhoneNumber, unique: true, name: "IX_UserPhoneNumber")
                .Index(t => t.ReversedPhoneNumber, unique: true, name: "IX_UserReversedPhoneNumber");
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.Users", "IX_UserReversedPhoneNumber");
            DropIndex("dbo.Users", "IX_UserPhoneNumber");
            DropIndex("dbo.Users", "IX_UserInternalToken");
            DropTable("dbo.Users");
        }
    }
}
