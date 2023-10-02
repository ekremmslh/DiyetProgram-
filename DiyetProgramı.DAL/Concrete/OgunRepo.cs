using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiyetProgramı.DAL.Abstract;
using DiyetProgramı.Entities.Concrete;
using DiyetProgramı.Entities.Enum;
using Microsoft.EntityFrameworkCore;

namespace DiyetProgramı.DAL.Concrete
{
    public class OgunRepo : BaseRepo<Ogun>
    {
        public OgunRepo(int kullaniciId) : base(kullaniciId)
        {
        }

        public override List<Ogun> GetAll()
        {
            return _dbSet.Include(x => x.Yemek).ToList();
        }
        public List<Ogun> HaftalikAylikRapor(DateTime baslangicTarihi, DateTime bitisTarihi, OgunIsmi ogunIsmi)
        {

            return _dbSet.Where(x =>
                 x.OgunVakti >= baslangicTarihi && x.OgunVakti <= bitisTarihi && x.OgunIsmi == ogunIsmi).ToList();
        }
        public List<Ogun> HaftalikAylikRaporKullanici(DateTime baslangicTarihi, DateTime bitisTarihi, OgunIsmi ogunIsmi)
        {

            return _dbSet.Include(x => x.Yemek).Where(x =>
                x.Yemek.KullaniciId == _kullaniciId && x.OgunVakti >= baslangicTarihi && x.OgunVakti <= bitisTarihi && x.OgunIsmi == ogunIsmi).ToList();
        }

        public decimal GunSonuToplamKalori(DateTime dateTime)
        {
            return _dbSet
                .Where(x => x.OgunVakti.Day == dateTime.Day && x.OgunVakti.Month == dateTime.Month &&
                            dateTime.Year == dateTime.Year).Sum(x => x.YenilenKalori);
        }
        public List<Ogun> GünSonuRapor(DateTime dateTime)
        {
            return _dbSet.Include(x=>x.Yemek).Where(x =>
                x.OgunVakti.Day == dateTime.Day && x.OgunVakti.Month == dateTime.Month &&
                dateTime.Year == dateTime.Year).ToList();
        }

        public override void Update(Ogun entity)
        {
            entity.YenilenKalori = entity.YemekPorsiyon * entity.Yemek.Kalori;
            base.Update(entity);
        }

    }
}
