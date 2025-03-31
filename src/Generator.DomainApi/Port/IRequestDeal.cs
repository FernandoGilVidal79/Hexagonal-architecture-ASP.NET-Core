using System.Collections.Generic;

namespace $safeprojectname$.DomainApi.Port
{
    public interface IRequestDeal<T>
    {
        List<T> GetDeals();
        T GetDeal(int id);
    }
}
