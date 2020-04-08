﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuaranTV.Repositories
{
    public class Repository<T> where T : class
    {
        private QuaranTvContext db;

        public Repository(QuaranTvContext db)
        {
            this.db = db;
        }
        public int Count()
        {
            return db.Set<T>().Count();
        }

        public void Create(T entity)
        {
            db.Set<T>().Add(entity);
            db.SaveChanges();
        }

        public void Update(T entity)
        {
            db.Set<T>().Update(entity);
            db.SaveChanges();
        }

        public T GetById(int id)
        {
            return db.Set<T>().Find(id);
        }

        public void Delete(T entity)
        {
            db.Set<T>().Remove(entity);
            db.SaveChanges();
        }

        public void Save()
        {
            // Save will persist all modifications to entities to the database.
            // Theres no great way to test this, and really we would be testing Microsoft's
            // code and not ours.  Untested code is the exception, not the norm.
            db.SaveChanges();
        }

        public IEnumerable<T> GetAll()
        {
            return db.Set<T>().ToList();
        }

        public virtual IEnumerable<T> GetByUserId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
