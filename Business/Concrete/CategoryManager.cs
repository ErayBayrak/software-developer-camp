using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
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
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public IResult Add(Category entity)
        {
            _categoryDal.Add(entity);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(Category entity)
        {
            _categoryDal.Delete(entity);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<Category> Get(Expression<Func<Category, bool>> filter)
        {
           return new SuccessDataResult<Category>(_categoryDal.Get(filter));
        }

        //public IDataResult<List<Category>> GetList()
        //{
        //    return new SuccessDataResult<List<Category>>(_categoryDal.GetAll(),Messages.ProductListed);
        //}

        public IDataResult<List<Category>> GetAll(Expression<Func<Category, bool>> filter = null)
        {
            return new SuccessDataResult<List<Category>>(_categoryDal.GetAll(filter));
        }

        public IDataResult<Category> GetById(int id)
        {
            return new SuccessDataResult<Category>(_categoryDal.Get(c=>c.CategoryId == id));
        }

        public IResult Update(Category entity)
        {
            _categoryDal.Update(entity);
            return new SuccessResult(Messages.Updated);
        }
    }
}
