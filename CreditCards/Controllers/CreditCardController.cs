using System;
using System.Web.Mvc;
using AutoMapper;
using CreditCards.Core.Domains;
using CreditCards.Core.Services;
using CreditCards.ViewModel;

namespace CreditCards.Controllers
{
    public class CreditCardController : Controller
    {
        private readonly ICardService _cardService;

        public CreditCardController(ICardService cardService)
        {
            _cardService = cardService;
        }

        public ActionResult SelectedCard(int? cardId)
        {
            var card = _cardService.GetCardById(cardId);

            var vm = Mapper.Map<CreditCardViewModel>(card);

            return View("SelectCard", vm);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ApplicationViewModel vm)
        {
            if (!ModelState.IsValid)
                throw new ApplicationException("Could not add user");

            var app = Mapper.Map<UserApplication>(vm);

            _cardService.ProcessApplicant(app);

            if (app.CreditCard == null)
                return View("NoCard");

            return RedirectToAction("SelectedCard", new {cardId = app.CardId});
        }
    }
}