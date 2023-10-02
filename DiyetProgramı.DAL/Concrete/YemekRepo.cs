using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using DiyetProgramı.Entities.Concrete;
using DiyetProgramı.Entities.Enum;
using Microsoft.EntityFrameworkCore;

namespace DiyetProgramı.DAL.Concrete
{
    public class YemekRepo : BaseRepo<Yemek>
    {
        public YemekRepo(int kullaniciId) : base(kullaniciId)
        {
        }

        public override List<Yemek> GetAll()
        {
            return _dbSet
                .Where(x=>x.KullaniciId == _kullaniciId)
                .ToList();
        }

        public List<YemekRaporu> YemekRapor()
        {
            return _dbSet
                .Include(x => x.Ogunler)
                .Where(x => x.Ogunler.Any(ogun => ogun.YemekId == x.Id))
                .Select(yemek => new YemekRaporu
                {
                    YemekAdi = yemek.YemekAdi,
                    Sabah = yemek.Ogunler
                        .Where(ogun => ogun.OgunIsmi == OgunIsmi.sabah)
                        .Sum(ogun => ogun.YemekPorsiyon),
                    Oglen = yemek.Ogunler
                        .Where(ogun => ogun.OgunIsmi == OgunIsmi.oglen)
                        .Sum(ogun => ogun.YemekPorsiyon),
                    Ikindi = yemek.Ogunler
                        .Where(ogun => ogun.OgunIsmi == OgunIsmi.ikindi)
                        .Sum(ogun => ogun.YemekPorsiyon),
                    Aksam = yemek.Ogunler
                        .Where(ogun => ogun.OgunIsmi == OgunIsmi.aksam)
                        .Sum(ogun => ogun.YemekPorsiyon),
                    Yatsi = yemek.Ogunler
                        .Where(ogun => ogun.OgunIsmi == OgunIsmi.yatsi)
                        .Sum(ogun => ogun.YemekPorsiyon)
                })
                .OrderByDescending(x => x.Aksam + x.Ikindi + x.Oglen + x.Sabah + x.Yatsi)
                .ToList();
        }
        public List<EnCokYemekRapor> EnCokYenenYemek()
        {
            var yemekRaporu = new List<EnCokYemekRapor>();
            var yemeklerDbx = _dbContext.Ogunler.Include(x => x.Yemek).Where(x => x.Yemek.KullaniciId == _kullaniciId).ToList(); 

            var count = yemeklerDbx.GroupBy(x=>x.Yemek.YemekAdi).Select(x=>new EnCokYemekRapor()
            {
                YemekAdi = x.Key,
                KacPorsiyon = x.Sum(x=>x.YemekPorsiyon),
                AlinanKalori = x.Sum(x=>x.YenilenKalori)
            }).OrderByDescending(x=>x.KacPorsiyon).Take(5).ToList();


            count.OrderByDescending(x => x.KacPorsiyon);
            return count;
        }

        public List<Yemek> GünSonuRapor(DateTime dateTime)
        {
            return _dbSet
                .Include(x => x.Ogunler)
                .Where(x => x.KullaniciId == _kullaniciId && x.Ogunler.Any(x => 
                                               x.OgunVakti.Day == dateTime.Day &&
                                               x.OgunVakti.Month == dateTime.Month &&
                                               x.OgunVakti.Year == dateTime.Year))
                .ToList();
        }

        public List<Yemek> HaftalikAylikRaporKullanici(DateTime baslangicTarihi, DateTime bitisTarihi, YemekKategorileri yemekKategorileri)
        {

            return _dbSet
                .Include(x => x.Ogunler)
                .Where(x => x.Kategorileri == yemekKategorileri && x.KullaniciId == _kullaniciId && x.Ogunler.Any(ogun =>
                                                  ogun.OgunVakti >= baslangicTarihi &&
                                                  ogun.OgunVakti <= bitisTarihi))
                .ToList();
        }
        public List<Yemek> HaftalikAylikRapor(DateTime baslangicTarihi, DateTime bitisTarihi, YemekKategorileri yemekKategorileri)
        {

            return _dbSet
                .Include(x => x.Ogunler)
                .Where(x => x.Ogunler.Any(ogun => ogun.OgunVakti >= baslangicTarihi &&
                                                        ogun.OgunVakti <= bitisTarihi && x.Kategorileri == yemekKategorileri))
                .ToList();
        }

        public override void Delete(Yemek entity)
        {
            if (_dbSet.Include(x => x.Ogunler).Any(x => x.Ogunler.Any(x => x.YemekId == entity.Id)))
                throw new Exception();
            _dbSet.Remove(entity);
            SaveChanges();

        }

        public override void Insert(Yemek entity)
        {
            entity.KullaniciId = _kullaniciId;
            base.Insert(entity);
        }
    }
}
