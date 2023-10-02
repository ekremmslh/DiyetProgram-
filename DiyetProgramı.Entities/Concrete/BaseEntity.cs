using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiyetProgramı.Entities.Abstract;

namespace DiyetProgramı.Entities.Concrete
{
    public abstract class BaseEntity : IEntity
    {
        public int Id { get; set; }
    }
}
