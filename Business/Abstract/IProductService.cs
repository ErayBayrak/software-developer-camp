using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IProductService
    {
        IDataResult<List<Product>> GetAll();
        IDataResult<List<Product>> GetProductByCategoryId(int id);
        IDataResult<List<Product>> GetByUnitPrice(decimal min,decimal max);
        IDataResult<List<ProductDetailDto>> GetProductDetails();
        IDataResult<List<Product>> GetAll(Expression<Func<Product, bool>> filter = null);
        IDataResult<Product> Get(Expression<Func<Product, bool>> filter);
        IDataResult<Product> GetById(int id);
        IResult Add(Product entity);
        void Update(Product entity);
        void Delete(Product entity);
    }
}
