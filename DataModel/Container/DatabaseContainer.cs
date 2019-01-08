using System.Data.Entity;
using System.Data.Entity.Migrations;
using DataModel.Entities;

namespace DataModel.Container
{
    public class DatabaseContainer : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Conclusion> Conclusions { get; set; }

        public DatabaseContainer() : base("name=myDB")
        {
            this.Configuration.EnsureTransactionsForFunctionsAndCommands = true;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UserMap());
            modelBuilder.Configurations.Add(new AddressMap());
            modelBuilder.Configurations.Add(new CompanyMap());
            modelBuilder.Configurations.Add(new ConclusionMap());
        }

        public void MigrateDb()
        {
            var dbMigrator = new DbMigrator(new Migrations.Configuration());
            dbMigrator.Update();
        }
    }
}
