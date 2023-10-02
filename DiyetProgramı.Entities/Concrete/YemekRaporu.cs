using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetProgramı.Entities.Concrete
{
    public class YemekRaporu
    {
        public string YemekAdi { get; set; }
        public decimal Sabah { get; set; }
        public decimal Oglen { get; set; }
        public decimal Ikindi { get; set; }
        public decimal Aksam { get; set; }
        public decimal Yatsi { get; set; }
        public override string ToString()
        {
            return
                $"{YemekAdi} - Sabah: {Sabah} - Öğlen: {Oglen} - İkindi: {Ikindi} - Akşam: {Aksam} - Yatsı: {Yatsi}";
        }
    }
}
