using System.Threading.Tasks;
using $safeprojectname$.DomainApi.Model;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;

namespace $safeprojectname$.Persistence.Adapter.UnitTest.Context
{
    public class ApplicationDbContextTest
    {
        [Test]
        public void CanInsertDealIntoDatabase()
        {
            using var context = ApplicationDbContextFactory.Create();
            var Deal = new Deal();
            context.Deals.Add(Deal);
            Assert.Equals(EntityState.Added, context.Entry(Deal).State);

            var result = context.SaveChangesAsync();
            Assert.Equals(1, result.Result);
            Assert.Equals(Task.CompletedTask.Status, result.Status);
            Assert.Equals(EntityState.Unchanged, context.Entry(Deal).State);

        }

        [Test]
        public void CanDeleteDealIntoDatabase()
        {
            using var context = ApplicationDbContextFactory.Create();
            var Deal = new Deal();
            context.Deals.Remove(Deal);
            Assert.Equals(EntityState.Deleted, context.Entry(Deal).State);
        }
    }
}
