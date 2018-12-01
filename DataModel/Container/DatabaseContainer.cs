using System.Data.Entity;
using System.Data.Entity.Migrations;
using DataModel.Models;

namespace DataModel.Container
{
    public class DatabaseContainer : DbContext
    {
        //public DbSet<User> Users { get; set; }
        //public DbSet<Transaction> Transactions { get; set; }
        //public DbSet<Subscription> Subscriptions { get; set; }
        //public DbSet<MerchantPOS> MerchantPOSes { get; set; }
        //public DbSet<Log> Logs { get; set; }
        //public DbSet<BonusProgram> BonusPrograms { get; set; }
        //public DbSet<Merchant> Merchants { get; set; }
        //public DbSet<Reward> Rewards { get; set; }
        //public DbSet<UsersInBonusProgram> UsersInBonusPrograms { get; set; }
        //public DbSet<Image> Images { get; set; }


        public DatabaseContainer() : base("name=myDB")
        {
            this.Configuration.EnsureTransactionsForFunctionsAndCommands = true;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Configurations.Add(new UserMap());
            //modelBuilder.Configurations.Add(new TransactionMap());
            //modelBuilder.Configurations.Add(new SubscriptionMap());
            //modelBuilder.Configurations.Add(new MerchantPOSMap());
            //modelBuilder.Configurations.Add(new LogMap());
            //modelBuilder.Configurations.Add(new BonusProgramMap());
            //modelBuilder.Configurations.Add(new MerchantMap());
            //modelBuilder.Configurations.Add(new RewardMap());
            //modelBuilder.Configurations.Add(new UsersInBonusProgramMap());
            //modelBuilder.Configurations.Add(new ImageMap());
        }

        public void MigrateDb()
        {
            var dbMigrator = new DbMigrator(new Migrations.Configuration());
            dbMigrator.Update();
        }
    }
}
