using System.Data.Entity.ModelConfiguration;
using CreditCards.Core.Domains;

namespace CreditCards.Core.Infrastructure.EntityConfig
{
    public class UserApplicationConfiguration : EntityTypeConfiguration<UserApplication>
    {
        public UserApplicationConfiguration()
        {
            HasKey(a => a.Id);

            Property(a => a.CardId)
                .IsOptional();

            Property(a => a.FirstName)
                .HasMaxLength(50);

            Property(a => a.LastName)
                .HasMaxLength(50);


            Property(a => a.DateOfBirth)
                .HasColumnType("date");

            Property(a => a.Income)
                .HasColumnType("decimal");
        }
    }
}