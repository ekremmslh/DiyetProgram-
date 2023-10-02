using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiyetProgramı.Entities.Abstract;
using DiyetProgramı.Entities.Concrete;

namespace DiyetProgramı.DAL.Abstract
{
    public interface IRepo<T> where T : class,IEntity
    {
        T GetById(int id);
        IEnumerable<T> GetAll();
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
        void SaveChanges();
    }
}
