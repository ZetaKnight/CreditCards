using AutoMapper;
using CreditCards.Core.Domains;
using CreditCards.ViewModel;

namespace CreditCards.AutoMapper
{
    public class DomainToViewModelMapping : Profile
    {
        public DomainToViewModelMapping()
        {
            CreateMap<CreditCard, CreditCardViewModel>();
            CreateMap<UserApplication, ApplicationViewModel>();
        }
    }
}