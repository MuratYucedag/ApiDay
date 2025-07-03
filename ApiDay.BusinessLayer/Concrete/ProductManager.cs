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
    public class ProductManager : IProductService
    {
        private readonly IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }
        public void TAdd(Product entity)
        {
            _productDal.Add(entity);
        }
        public void TDelete(int id)
        {
            _productDal.Delete(id);
        }
        public Product TGetById(int id)
        {
            return _productDal.GetById(id);
        }
        public List<Product> TGetListAll()
        {
            return _productDal.GetListAll();
        }
        public void TUpdate(Product entity)
        {
            _productDal.Update(entity);
        }
    }
}
