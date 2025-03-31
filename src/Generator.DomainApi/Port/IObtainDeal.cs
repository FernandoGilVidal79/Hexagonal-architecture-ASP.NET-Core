using $safeprojectname$.DomainApi.Model;
using System.Collections.Generic;

namespace $safeprojectname$.DomainApi.Port
{
    public interface IObtainDeal<T>
    {
        List<Deal> GetDeals();
        Deal GetDeal(T id);
    }
}
