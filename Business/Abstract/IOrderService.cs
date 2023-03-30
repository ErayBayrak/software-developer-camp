using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IOrderService
    {
        List<Order> GetAll(Expression<Func<Order, bool>> filter = null);
        Order Get(Expression<Func<Order, bool>> filter);
        void Add(Order entity);
        void Update(Order entity);
        void Delete(Order entity);
    }
}
