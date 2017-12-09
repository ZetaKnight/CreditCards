using CreditCards.Core.Domains;

namespace CreditCards.Core.Services
{
    public interface ICardService
    {
        void ProcessApplicant(UserApplication user);
        CreditCard GetCardById(int? cardId);
    }
}