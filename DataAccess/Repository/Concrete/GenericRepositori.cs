using DataAccess.Concrete.Context;
using DataAccess.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository.Concrete
{
    public class GenericRepositori<T> : IGenericDal<T> where T : class
    {
        public void Add(T entity)
        {
            using (CongressContext context = new CongressContext())
            {
                context.Add(entity);
                context.SaveChanges();
            }
        }

        public void Delete(T entity)
        {
            using (CongressContext context = new CongressContext())
            {
                context.Remove(entity);
                context.SaveChanges();
            }
        }

        public List<T> GetAll(Expression<Func<T, bool>> filter)
        {
            using (CongressContext context = new CongressContext())
            {
                return context.Set<T>().Where(filter).ToList();
            }
        }

        public List<T> GetAll()
        {
            using (CongressContext context = new CongressContext())
            {
                return context.Set<T>().ToList();
            }
        }

        public T GetById(int id)
        {
            using (CongressContext context = new CongressContext())
            {
                return context.Set<T>().Find(id);
            }
        }

        public void Update(T entity)
        {
            using (CongressContext context = new CongressContext())
            {
                context.Update(entity);
                context.SaveChanges();
            }
        }
    }
}
