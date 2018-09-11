using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication3.Models;

namespace CodeFirst
{
    public class Repository<T> where T : class
    {
        public void Remove(T entity)
        {
            using (var dbContext = new ApplicationDbContext())
            {
                var item = dbContext.Set<T>().Remove(entity);
                dbContext.SaveChanges();
            }
        }

        public void Add(T item)
        {
            using (var dbContext = new ApplicationDbContext())
            {
                dbContext.Set<T>().Add(item);
                dbContext.SaveChanges();
            }
        }

        public void Edit(T item)
        {
            using (var dbContext = new ApplicationDbContext())
            {
                dbContext.Entry(item).State = System.Data.Entity.EntityState.Modified;
                dbContext.SaveChangesAsync();
            }
        }
    }
}
