using ApiDay.DataAccessLayer.Abstract;
using ApiDay.DataAccessLayer.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiDay.DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        private readonly ApiContext _context;
        public GenericRepository(ApiContext context)
        {
            _context = context;
        }
        public void Add(T entity)
        {
            _context.Set<T>().Add(entity);
            _context.SaveChanges();
        }
        public void Delete(int id)
        {
            var value = _context.Set<T>().Find(id);
            _context.Remove(value);
            _context.SaveChanges();
        }
        public T GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }
        public List<T> GetListAll()
        {
            return _context.Set<T>().ToList();
        }
        public void Update(T entity)
        {
            _context.Set<T>().Update(entity);
            _context.SaveChanges();
        }
    }
}
