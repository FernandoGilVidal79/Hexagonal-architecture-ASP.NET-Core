using $safeprojectname$.DomainApi.Model;
using $safeprojectname$.DomainApi.Port;
using $safeprojectname$.RestAdapter.Controllers.v1;
using Microsoft.AspNetCore.Mvc;
using Moq;
using NUnit.Framework;

namespace $safeprojectname$.RestAdapter.UnitTest.Controllers
{
    public class DealControllerTest
    {
        private DealController _controller;
        private Mock<IRequestDeal<Deal>> _requestDealMock;

        [SetUp]
        public void Setup()
        {
            _requestDealMock = new Mock<IRequestDeal<Deal>>();
            _controller = new DealController(_requestDealMock.Object);
        }

        [Test]
        public void GetAllDealTestOkResult()
        {
            var response = _controller.Get();
            Assert.That(response, Is.InstanceOf<OkObjectResult>());
        }

        [Test]
        public void GetAllDealByIdTestOkResult()
        {
            var response = _controller.Get(1);
            Assert.That(response, Is.InstanceOf<OkObjectResult>());
        }
    }
}
