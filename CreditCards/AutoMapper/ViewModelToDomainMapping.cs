using AutoMapper;
using CreditCards.Core.Domains;
using CreditCards.ViewModel;

namespace CreditCards.AutoMapper
{
    public class ViewModelToDomainMapping : Profile
    {
        public ViewModelToDomainMapping()
        {
            CreateMap<CreditCardViewModel, CreditCard>();
            CreateMap<ApplicationViewModel, UserApplication>();
        }
    }
}
