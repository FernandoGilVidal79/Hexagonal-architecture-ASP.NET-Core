﻿using System.Collections.Generic;
using $safeprojectname$.DomainApi.Model;
using $safeprojectname$.DomainApi.Port;

namespace $safeprojectname$.Domain
{
    public class DealDomain<T> : IRequestDeal<T> where T : Deal
    {
        private readonly IDealSet table;

        public DealDomain(IApplicationDbContext dbContext)
        {
            IApplicationDbContext _dbContext;
            _dbContext = dbContext;
            table = _dbContext.Deals;
        }
        public T GetDeal(int id)
        {
            return table.Find<T>(id);
        }

        public List<T> GetDeals()
        {
            return table.ToList<T>();
        }
    }
}
