using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiyetProgramı.DAL.Concrete;
using DiyetProgramı.Entities.Abstract;

namespace DiyetProgramı.BLL.Abstract
{
    public interface IService<T> where T : IEntity
    {
        T GetByIdManager(int id);
        IEnumerable<T> GetAllManager();
        void InsertManager(T entity);
        void UpdateManager(T entity);
        void DeleteManager(T entity);
    }
}
