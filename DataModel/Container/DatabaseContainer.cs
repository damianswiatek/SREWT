using System.Data.Entity;
using System.Data.Entity.Migrations;
using DataModel.Entities;

namespace DataModel.Container
{
    public class DatabaseContainer : DbContext
    {
        public DbSet<User> Users { get; set; }
        
        public DatabaseContainer() : base("name=myDB")
        {
            this.Configuration.EnsureTransactionsForFunctionsAndCommands = true;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UserMap());
        }

        public void MigrateDb()
        {
            var dbMigrator = new DbMigrator(new Migrations.Configuration());
            dbMigrator.Update();
        }
    }
}
