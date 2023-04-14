using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICategoryService
    {
        //IDataResult<List<Category>> GetList();
        IDataResult<Category> GetById(int id);
        IDataResult<List<Category>> GetAll(Expression<Func<Category, bool>> filter = null);
        IDataResult<Category> Get(Expression<Func<Category, bool>> filter);
        IResult Add(Category entity);
        IResult Update(Category entity);
        IResult Delete(Category entity);
    }
}
