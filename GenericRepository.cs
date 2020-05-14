using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameworkCorePractice
{
    class GenericRepository<T> where T : class
    {
        private MyDbContext db;
        private DbSet<T> dbSet;
        
        public GenericRepository()
        {
            db = new MyDbContext();
            dbSet = db.Set<T>();
        }
        public void Insert(T obj)
        {
            dbSet.Add(obj);
        }

        public void Remove(T obj)
        {
            dbSet.Remove(obj);
        }

        public void Update(T obj)
        {
            dbSet.Attach(obj);
            db.Entry(obj).State = EntityState.Modified;
        }

        public IEnumerable<T> GetAll()
        {
            return dbSet;
        }
        public void Save()
        {
            db.SaveChanges();
        }

    }
}
