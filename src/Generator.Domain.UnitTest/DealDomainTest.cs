using Generator.DomainApi.Model;
using Generator.Persistence.Adapter;
using NUnit.Framework;

namespace Generator.Domain.UnitTest
{
    public class DealDomainTest
    {
        private DealDomain<Deal> _dealDomain;

        [Test]
        public void GetDealsTest()
        {
            using var context = ApplicationDbContextFactory.Create();
            _dealDomain = new DealDomain<Deal>(context);
            var deals = _dealDomain.GetDeals();
            Assert.Equals(3, deals.Count);
            Assert.Equals(1, deals[0].Id);
            Assert.Equals("ABC", deals[0].Name);
            Assert.Equals("ABC deal 123", deals[0].Description);
        }

        [Test]
        public void GetDealByIdTest()
        {
            using var context = ApplicationDbContextFactory.Create();
            _dealDomain = new DealDomain<Deal>(context);
            var deals = _dealDomain.GetDeal(1);
            Assert.Equals(1, deals.Id);
            Assert.Equals("ABC", deals.Name);
            Assert.Equals("ABC deal 123", deals.Description);

        }
    }
}