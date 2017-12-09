using System.Linq;
using CreditCards.Core.Domains;
using CreditCards.Core.Infrastructure.Context;

namespace CreditCards.Core.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly CreditCardDbContext _context;

        public UserRepository(CreditCardDbContext context)
        {
            _context = context;
        }

        public void Add(UserApplication user)
        {
            _context.Applications.Add(user);
            _context.SaveChanges();
        }

        public CreditCard GetCardById(int? id)
        {
            return _context.CreditCards.FirstOrDefault(x => x.Id == id);
        }

        public IQueryable<CreditCard> GetBarclaysCard()
        {
            return _context.CreditCards.Where(x => x.Name == "Barclays");
        }

        public IQueryable<CreditCard> GetVanquisCard()
        {
            return _context.CreditCards.Where(x => x.Name == "Vanquis");
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}