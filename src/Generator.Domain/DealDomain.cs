﻿using System.Collections.Generic;
using Generator.DomainApi.Model;
using Generator.DomainApi.Port;

namespace Generator.Domain
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
