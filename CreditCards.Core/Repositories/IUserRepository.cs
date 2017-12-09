using System.Linq;
using CreditCards.Core.Domains;

namespace CreditCards.Core.Repositories
{
    public interface IUserRepository
    {
        /// <summary>
        ///     Persist User Application
        /// </summary>
        /// <param name="user"></param>
        void Add(UserApplication user);

        /// <summary>
        ///     Get a card by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        CreditCard GetCardById(int? id);

        /// <summary>
        ///     Both these methods go get the cards by desinated name
        /// </summary>
        /// <returns></returns>
        IQueryable<CreditCard> GetBarclaysCard();

        IQueryable<CreditCard> GetVanquisCard();

        void Dispose();
    }
}