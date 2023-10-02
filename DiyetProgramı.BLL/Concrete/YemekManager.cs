using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using DiyetProgramı.DAL.Concrete;
using DiyetProgramı.Entities.Concrete;
using DiyetProgramı.Entities.Enum;
using Microsoft.EntityFrameworkCore;

namespace DiyetProgramı.BLL.Concrete
{
    public class YemekManager : BaseManager<Yemek>
    {
        private YemekRepo _repo;
        private List<Yemek> _yemeks;
        public YemekManager(BaseRepo<Yemek> baseRepo) : base(baseRepo)
        {
            _repo = (YemekRepo)baseRepo;
        }
        public  List<Yemek> GetAll()
        {
            return _repo.GetAll();
        }

        public List<EnCokYemekRapor> EnCokYenenYemek()
        {
            return _repo.EnCokYenenYemek();
        }

        public List<YemekRaporu> YemekRaporu()
        {
            return _repo.YemekRapor();
        }

        public decimal HaftalikAylikRaporKategoriMax(DateTime baslangicTarihi, DateTime bitisTarihi,YemekKategorileri yemekKategorileri)
        {
            _yemeks = new List<Yemek>();
            _yemeks = _repo.HaftalikAylikRapor(baslangicTarihi, bitisTarihi, yemekKategorileri);
            if (_yemeks.Count == 0)
            {
                return default;
            }
            return _yemeks.Max(x => x.Ogunler.Max(x=>x.YenilenKalori));
        }
        public decimal HaftalikAylikRaporKategoriMin(DateTime baslangicTarihi, DateTime bitisTarihi, YemekKategorileri yemekKategorileri)
        {
            _yemeks = new List<Yemek>();
            _yemeks = _repo.HaftalikAylikRapor(baslangicTarihi, bitisTarihi, yemekKategorileri);
            if (_yemeks.Count == 0)
            {
                return default;
            }
            return _yemeks.Min(x => x.Ogunler.Min(x => x.YenilenKalori));
        }
        public decimal HaftalikAylikRaporKategoriAvg(DateTime baslangicTarihi, DateTime bitisTarihi, YemekKategorileri yemekKategorileri)
        {
            _yemeks = new List<Yemek>();
            _yemeks = _repo.HaftalikAylikRapor(baslangicTarihi, bitisTarihi, yemekKategorileri);
            if (_yemeks.Count == 0)
            {
                return default;
            }
            return _yemeks.Average(x => x.Ogunler.Average(x => x.YenilenKalori));
        }

        public decimal HaftalikAylikRaporKullanici(DateTime baslangicTarihi, DateTime bitisTarihi,YemekKategorileri yemekKategorileri)
        {
            _yemeks = new List<Yemek>();
            _yemeks = _repo.HaftalikAylikRaporKullanici(baslangicTarihi, bitisTarihi, yemekKategorileri);
            if (_yemeks.Count == 0)
            {
                return default;
            }
            return _yemeks.Average(x => x.Ogunler.Average(x => x.YenilenKalori));
        }

    }
}
