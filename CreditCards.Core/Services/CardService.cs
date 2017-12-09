using System;
using System.Linq;
using AutoMapper;
using CreditCards.Core.Domains;
using CreditCards.Core.Repositories;

namespace CreditCards.Core.Services
{
    public class CardService : ICardService
    {
        private readonly IUserRepository _userRepository;

        public CardService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }


        public void ProcessApplicant(UserApplication user)
        {
            if (user == null)
                throw new ArgumentNullException(nameof(user));

            var eighteenYrsAgo = DateTime.Now.Date.AddYears(-18);

            CreditCard card = null;

            if (user.DateOfBirth <= eighteenYrsAgo && user.Income > 30000)
                card = _userRepository.GetBarclaysCard().Single();
            else if (user.DateOfBirth <= eighteenYrsAgo)
                card = _userRepository.GetVanquisCard().Single();

            if (card != null)
                user.CreditCard = card;

            _userRepository.Add(user);
        }

        public CreditCard GetCardById(int? cardId)
        {
            var card = _userRepository.GetCardById(cardId);

            return Mapper.Map<CreditCard>(card);
        }
    }
}