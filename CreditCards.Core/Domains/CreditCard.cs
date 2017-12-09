using System.ComponentModel.DataAnnotations;

namespace CreditCards.Core.Domains
{
    public class CreditCard
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        public string Apr { get; set; }
        public string PromoMessage { get; set; }
    }
}