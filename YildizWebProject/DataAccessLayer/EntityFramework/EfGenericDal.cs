using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfGenericDal<T> : IGenericDal<T> where T : class
    {
        Context context;
        DbSet<T> _object;
        public EfGenericDal()
        {
            _object = context.Set<T>();
        }

        public T GetById(Expression<Func<T, bool>> filter)
        {
            return _object.SingleOrDefault(filter);
        }

        public List<T> GetList()
        {
            return _object.ToList();
        }

        public void Insert(T t)
        {
            var addedItem = context.Entry(t);
            addedItem.State = EntityState.Added;
            context.SaveChanges();
        }

        public void Remove(T t)
        {
            var deletedItem= context.Entry(t);
            deletedItem.State = EntityState.Deleted;
            context.SaveChanges();
        }

        public void Update(T t)
        {
            var updatedItem = context.Entry(t);
            updatedItem.State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}
