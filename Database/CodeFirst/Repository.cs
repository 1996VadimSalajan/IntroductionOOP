using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst
{
    class Repository<T> where T:class
    {
        public void Add(T entity)
        {
            using (var dbContext = new MoodleContext())
            {
                dbContext.Set<T>().Add(entity);
                dbContext.SaveChanges();
            }
        }
        public void Update(T entity)
        {
            using (var dbContext = new MoodleContext())
            {
                dbContext.Entry(entity).State = EntityState.Modified;
                dbContext.SaveChanges();
            }
        }
        public void Delete(T entity)
        {
            using (var dbContext = new MoodleContext())
            {
                dbContext.Entry(entity).State = EntityState.Deleted;
                dbContext.SaveChanges();
            }
        }
    }
}
