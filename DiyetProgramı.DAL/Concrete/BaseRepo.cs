using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using DiyetProgramı.DAL.Abstract;
using DiyetProgramı.DAL.Context;
using DiyetProgramı.Entities.Abstract;
using Microsoft.EntityFrameworkCore;

namespace DiyetProgramı.DAL.Concrete
{
    public abstract class BaseRepo<T> : IRepo<T> where T : class,IEntity
    {
        protected DbSet<T> _dbSet;
        internal DiyetProgramıDbContext _dbContext;
        public int _kullaniciId;

        public BaseRepo(int kullaniciId)
        {
            _dbContext = new DiyetProgramıDbContext();
            _dbSet = _dbContext.Set<T>();
            _kullaniciId = kullaniciId;
        }

        public BaseRepo()
        {
            _dbContext = new DiyetProgramıDbContext();
            _dbSet = _dbContext.Set<T>();
        }
        public virtual T GetById(int id)
        {
            return _dbSet.SingleOrDefault(x => x.Id == id);
        }

        public virtual IEnumerable<T> GetAll()
        {
            return _dbSet.ToList();
        }

        public virtual void Insert(T entity)
        {
            _dbSet.Add(entity);
            SaveChanges();
        }

        public virtual void Update(T entity)
        {
            SaveChanges();
        }

        public virtual void Delete(T entity)
        {
            _dbSet.Remove(entity);
            SaveChanges();
        }


        public void SaveChanges()
        {
            _dbContext.SaveChanges();
        }
    }
}
