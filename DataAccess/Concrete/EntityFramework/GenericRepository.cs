using DataAccess.Abstract;
using DataAccess.Concrete;
using Entities.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class, IEntity, new()
    {
        
        public void Add(T entity)
        {
            using (Context context = new Context())
            {
                var added = context.Entry(entity);
                added.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(T entity)
        {
            using(Context context=new Context())
            {
                var deleted = context.Entry(entity);
                deleted.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public List<T> GetAll()
        {
           using(Context context=new Context())
            {
                return context.Set<T>().ToList();
            }
        }

        public T GetById(int id)
        {
            using(Context context=new Context())
            {
                return context.Set<T>().Find(id);
            }
        }

        public void Update(T entity)
        {
            using(Context context=new Context())
            {
                var updated = context.Entry(entity);
                updated.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
