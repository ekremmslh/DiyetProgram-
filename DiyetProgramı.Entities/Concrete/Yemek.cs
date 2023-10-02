using System.Security.AccessControl;
using DiyetProgramı.Entities.Abstract;
using DiyetProgramı.Entities.Enum;

namespace DiyetProgramı.Entities.Concrete;

public class Yemek : BaseEntity
{
    public decimal Kalori { get; set; }
    public YemekKategorileri Kategorileri { get; set; }
    public string YemekAdi { get; set; }
    public string? ResimYolu { get; set; }
    public int KullaniciId { get; set; }

    public Kullanici Kullanici { get; set; }

    public List<Ogun> Ogunler { get; set; } = new List<Ogun>();

}