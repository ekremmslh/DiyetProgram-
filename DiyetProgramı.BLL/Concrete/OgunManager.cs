using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiyetProgramı.DAL.Concrete;
using DiyetProgramı.Entities.Concrete;
using DiyetProgramı.Entities.Enum;
using Microsoft.EntityFrameworkCore;

namespace DiyetProgramı.BLL.Concrete
{
    public class OgunManager : BaseManager<Ogun>
    {
        private OgunRepo _repo;
        private List<Ogun> _oguns;
        public OgunManager(BaseRepo<Ogun> baseRepo) : base(baseRepo)
        {
            _repo = (OgunRepo?)baseRepo;
        }

        public List<Ogun> GetAll()
        {
            return _repo.GetAll();
        }
        public List<Ogun> GetAllDaily(DateTime dateTime)
        {
            return _repo.GetAll().Where(x=>x.OgunVakti.Year == dateTime.Year && x.OgunVakti.Month == dateTime.Month && x.OgunVakti.Day == dateTime.Day).ToList();
        }
        public decimal HaftalikAylikRaporMax(DateTime baslangicTarihi, DateTime bitisTarihi,OgunIsmi ogunIsmi)
        {
            _oguns = new List<Ogun>();
            _oguns = _repo.HaftalikAylikRapor(baslangicTarihi, bitisTarihi, ogunIsmi);
            if (_oguns.Count == 0)
            {
                return default;
            }
            return _oguns.Max(x=>x.YenilenKalori);
        }
        public decimal HaftalikAylikRaporMin(DateTime baslangicTarihi, DateTime bitisTarihi, OgunIsmi ogunIsmi)
        {
            _oguns = new List<Ogun>();
            _oguns = _repo.HaftalikAylikRapor(baslangicTarihi, bitisTarihi, ogunIsmi);
            if (_oguns.Count == 0)
            {
                return default;
            }
            return _oguns.Min(x => x.YenilenKalori);
        }
        public decimal HaftalikAylikRaporAvg(DateTime baslangicTarihi, DateTime bitisTarihi, OgunIsmi ogunIsmi)
        {
            _oguns = new List<Ogun>();
            _oguns = _repo.HaftalikAylikRapor(baslangicTarihi, bitisTarihi, ogunIsmi);
            if (_oguns.Count == 0)
            {
                return default;
            }
            return _oguns.Average(x => x.YenilenKalori);
        }

        public decimal HaftalikAylikRaporKullaniciAvg(DateTime baslangicTarihi, DateTime bitisTarihi, OgunIsmi ogunIsmi)
        {
            _oguns = new List<Ogun>();
            _oguns = _repo.HaftalikAylikRaporKullanici(baslangicTarihi, bitisTarihi, ogunIsmi);
            if (_oguns.Count == 0)
            {
                return default;
            }
            return _oguns.Average(x => x.YenilenKalori);
        }

        public decimal GunSonuToplamKalori(DateTime dateTime)
        {
            return _repo.GunSonuToplamKalori(dateTime);
        }

        public List<Ogun> GünSonuRapor(DateTime dateTime)
        {
            return _repo.GünSonuRapor(dateTime);
        }

    }
}
