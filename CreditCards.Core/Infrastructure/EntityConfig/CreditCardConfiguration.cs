using System.Data.Entity.ModelConfiguration;
using CreditCards.Core.Domains;

namespace CreditCards.Core.Infrastructure.EntityConfig
{
    public class CreditCardConfiguration : EntityTypeConfiguration<CreditCard>
    {
        public CreditCardConfiguration()
        {
            HasKey(a => a.Id);

            Property(a => a.Name)
                .HasMaxLength(50);

            Property(a => a.Apr);

            Property(a => a.PromoMessage)
                .HasMaxLength(300);
        }
    }
}