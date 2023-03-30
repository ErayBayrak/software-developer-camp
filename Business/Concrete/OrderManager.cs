using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class OrderManager : IOrderService
    {
        IOrderDal _orderDal;
        public OrderManager(IOrderDal orderDal)
        {
            _orderDal = orderDal;
        }
        public void Add(Order entity)
        {
            _orderDal.Add(entity);
        }

        public void Delete(Order entity)
        {
            _orderDal.Delete(entity);
        }

        public Order Get(Expression<Func<Order, bool>> filter)
        {
            return _orderDal.Get(filter);
        }

        public List<Order> GetAll(Expression<Func<Order, bool>> filter = null)
        {
            return _orderDal.GetAll(filter);
        }

        public void Update(Order entity)
        {
            _orderDal.Update(entity);
        }
    }
}
