using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiyetProgramı.BLL.Abstract;
using DiyetProgramı.DAL.Concrete;
using DiyetProgramı.Entities.Abstract;

namespace DiyetProgramı.BLL.Concrete
{
    public class BaseManager<T> : IService<T> where T : class, IEntity
    {
        protected BaseRepo<T> _repo;
        public BaseManager(BaseRepo<T> baseRepo)
        {
            _repo = baseRepo;
        }
        public virtual T GetByIdManager(int id)
        {
           return _repo.GetById(id);
        }

        public IEnumerable<T> GetAllManager()
        {
            return _repo.GetAll();
        }

        public virtual void InsertManager(T entity)
        {
            _repo.Insert(entity);
        }

        public virtual void UpdateManager(T entity)
        {
            _repo.Update(entity);
        }

        public void DeleteManager(T entity)
        {
            _repo.Delete(entity);
        }
    }
}
