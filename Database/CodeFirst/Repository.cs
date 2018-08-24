using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst
{
    class Repository<T> where T : class
    {
        private readonly MoodleContext moodleContext;

        public Repository(MoodleContext moodleContext)
        {
            this.moodleContext = moodleContext;
        }  
        public void Add(T entity)
        {

            moodleContext.Set<T>().Add(entity);
        }
        public void Update(T entity)
        {
            moodleContext.Entry(entity).State = EntityState.Modified;
        }
        public void Delete(T entity)
        {
            moodleContext.Entry(entity).State = EntityState.Deleted;
        }
        public void Save()
        {
            moodleContext.SaveChanges();
        }
    }
}
