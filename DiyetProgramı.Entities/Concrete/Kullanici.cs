using DiyetProgramı.Entities.Abstract;
using DiyetProgramı.Entities.Enum;

namespace DiyetProgramı.Entities.Concrete;

public class Kullanici : BaseEntity
{
    public string KullaniciMail { get; set; }
    public string KullaniciSifre { get; set; }
    public string KullaniciAdi { get; set; }
    public string KullaniciSoyadi { get; set; }
    public int KullaniciYasi { get; set; }
    public decimal KullaniciKilo { get; set; }
    public int KullaniciBoy { get; set; }

    //Nav Property
    public List<Yemek> Yemekler { get; set; } = new List<Yemek>();
}