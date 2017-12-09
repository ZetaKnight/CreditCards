using System;
using System.ComponentModel.DataAnnotations;
using CreditCards.Core.Domains;

namespace CreditCards.ViewModel
{
    public class ApplicationViewModel
    {
        [Required(ErrorMessage = "Please Enter First Name")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please Enter Last Name")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Date Of Birth")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DateOfBirth { get; set; }

        [Required(ErrorMessage = "Please Enter Income")]
        [Display(Name = "Income")]
        public decimal Income { get; set; }

        public int? CardId { get; set; }
        public CreditCard CreditCard { get; set; }
    }
}