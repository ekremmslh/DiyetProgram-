using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using DiyetProgramı.Entities.Concrete;

namespace DiyetProgramı.DAL.Concrete
{
    public class KullaniciRepo : BaseRepo<Kullanici>
    {

        public KullaniciRepo() : base()
        {
        }

        public bool ValidUser(string username)
        {
            if(_dbSet.Any(x=>x.KullaniciMail == username))
                return false;
            return true;
        }

        public int UserLogin(string email,string password)
        {
            var user = _dbSet.SingleOrDefault(x => x.KullaniciMail == email);
            if(user == null) 
                return -1;
            if (user.KullaniciSifre != password)
                return -1;
            return user.Id;
        }

        public int GetUserId(string userName)
        {
            return  _dbSet.Single(x => x.KullaniciMail == userName).Id;
        }
    }
    
}
