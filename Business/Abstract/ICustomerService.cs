﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICustomerService
    {
        List<Customer> GetAll(Expression<Func<Customer, bool>> filter = null);
        Customer Get(Expression<Func<Customer, bool>> filter);
        void Add(Customer entity);
        void Update(Customer entity);
        void Delete(Customer entity);
    }
}
