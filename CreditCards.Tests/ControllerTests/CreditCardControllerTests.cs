using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreditCards.Controllers;
using CreditCards.Core.Services;
using Moq;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace CreditCards.Tests.ControllerTests
{
    [TestFixture()]
    public class CreditCardControllerTests
    {
        private Mock<ICardService> _serviceMock;
        private CreditCardController _controller;

        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void Create()
        {

        }

        [Test]
        public void SelectedCard()
        {

        }

        [Test]
        public void NoCard()
        {

        }

    }
}
