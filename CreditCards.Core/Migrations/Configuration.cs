using System;
using System.Data.Entity.Migrations;
using CreditCards.Core.Domains;
using CreditCards.Core.Infrastructure.Context;

namespace CreditCards.Core.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<CreditCardDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(CreditCardDbContext context)
        {
            context.Applications.AddOrUpdate(x => x.Id,
                new UserApplication
                {
                    Id = 1,
                    CardId = 1,
                    FirstName = "Mike",
                    LastName = "Thomas",
                    DateOfBirth = DateTime.Now.Date,
                    Income = 1000
                },
                new UserApplication
                {
                    Id = 2,
                    CardId = 2,
                    FirstName = "Amar",
                    LastName = "Chavda",
                    DateOfBirth = DateTime.Now.Date,
                    Income = 1000
                }
            );

            context.CreditCards.AddOrUpdate(x => x.Id,
                new CreditCard
                {
                    Id = 1,
                    Name = "Barclays",
                    PromoMessage = "You can get barlays card on offer for 19.99 per month",
                    Apr = "3.00 %"
                },
                new CreditCard
                {
                    Id = 2,
                    Name = "Vanquis",
                    PromoMessage = "You can get Vanquis card free if you are a student",
                    Apr = "1.12 %"
                }
            );
        }
    }
}