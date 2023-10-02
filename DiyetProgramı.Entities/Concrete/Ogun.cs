using DiyetProgramı.Entities.Enum;

namespace DiyetProgramı.Entities.Concrete;

public class Ogun : BaseEntity
{
    public OgunIsmi OgunIsmi { get; set; }
    public DateTime OgunVakti { get; set; }
    public decimal YemekPorsiyon { get; set; }
    public decimal YenilenKalori { get; set; }
    public int YemekId { get; set; }

    //Nav Property
    public Yemek Yemek { get; set; }
}