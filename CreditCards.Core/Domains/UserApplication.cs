using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CreditCards.Core.Domains
{
    public class UserApplication
    {
        [Key]
        public int Id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public decimal Income { get; set; }

        [ForeignKey("CreditCard")]
        public int? CardId { get; set; }

        public CreditCard CreditCard { get; set; }
    }
}