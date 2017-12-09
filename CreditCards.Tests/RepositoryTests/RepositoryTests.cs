using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreditCards.Core.Infrastructure.Context;
using CreditCards.Core.Repositories;
using Moq;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace CreditCards.Tests.RepositoryTests
{
    [TestFixture()]
    public class RepositoryTests
    {
        private Mock<CreditCardDbContext> _mockContext;
        private IUserRepository _repository;

        [SetUp]
        public void Setup()
        {

        }


    }
}
