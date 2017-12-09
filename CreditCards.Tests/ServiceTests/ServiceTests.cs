using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreditCards.Core.Domains;
using CreditCards.Core.Repositories;
using CreditCards.Core.Services;
using Moq;
using NUnit.Framework;

namespace CreditCards.Tests.ServiceTests
{
    /// <summary>
    /// Integration Test
    /// </summary>
    [TestFixture]
    public class ServiceTests
    {
        private Mock<IUserRepository> _repoMock;
        private ICardService _service;

        private UserApplication _user;
        private CreditCard _creditCard;

        [SetUp]
        public void Setup()
        {
            
        }


    }
}
