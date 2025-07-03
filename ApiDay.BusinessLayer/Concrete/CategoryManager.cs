using ApiDay.BusinessLayer.Abstract;
using ApiDay.DataAccessLayer.Abstract;
using ApiDay.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiDay.BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }
        public void TAdd(Category entity)
        {
            _categoryDal.Add(entity);
        }
        public void TDelete(int id)
        {
            _categoryDal.Delete(id);
        }
        public Category TGetById(int id)
        {
            return _categoryDal.GetById(id);
        }
        public List<Category> TGetListAll()
        {
            return _categoryDal.GetListAll();
        }
        public void TUpdate(Category entity)
        {
            _categoryDal.Update(entity);
        }
    }
}
