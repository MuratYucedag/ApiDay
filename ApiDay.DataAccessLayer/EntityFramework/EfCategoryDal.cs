using ApiDay.DataAccessLayer.Abstract;
using ApiDay.DataAccessLayer.Context;
using ApiDay.DataAccessLayer.Repositories;
using ApiDay.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiDay.DataAccessLayer.EntityFramework
{
    public class EfCategoryDal : GenericRepository<Category>, ICategoryDal
    {
        public EfCategoryDal(ApiContext context) : base(context)
        {
        }
    }
}
