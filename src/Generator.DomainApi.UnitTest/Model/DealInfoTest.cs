using Generator.DomainApi.Model;
using NUnit.Framework;
using System.Collections.Generic;

namespace Generator.DomainApi.UnitTest.Model
{
    public class DealInfoTest
    {
        private readonly DealInfo _dealInfo;

        public DealInfoTest()
        {
            _dealInfo = new DealInfo();
        }

        [Test]
        public void TestSetAndGetName()
        {
            _dealInfo.Deals = GetDeals();
            Assert.Equals(_dealInfo.Deals.Count > 0, true);
        }

        private static List<Deal> GetDeals()
        {
            return
                new List<Deal> { new Deal { Description = "", Name = "" } };
        }
    }
}
