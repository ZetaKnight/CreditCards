using System.Data.Entity;
using CreditCards.Core.Domains;
using CreditCards.Core.Infrastructure.EntityConfig;

namespace CreditCards.Core.Infrastructure.Context
{
    public class CreditCardDbContext : DbContext
    {
        public CreditCardDbContext() : base("CreditCardDb")
        {
            Database.SetInitializer<CreditCardDbContext>(null);
            Configuration.AutoDetectChangesEnabled = false;
        }

        public DbSet<CreditCard> CreditCards { get; set; }
        public DbSet<UserApplication> Applications { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CreditCardConfiguration());
            modelBuilder.Configurations.Add(new UserApplicationConfiguration());
        }
    }
}