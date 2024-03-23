using ConsoleApp1.Exceptions;

namespace ConsoleApp1;

public class LiquidContainer : IContainerBase, IHazardNotifier
{
    public double MasaLadunku { get; set; }
    public double Wysokosc { get; set; }
    public double WagaWlasna { get; set; }
    public int Glebokosc { get; set; }
    public string NumerySeryjne { get; set; }
    public double MaksymalnaMasaLadunku { get; set; }
    public static int count { get; set; }
    public bool IsHazard { get; }
    
    public LiquidContainer(string typ, double masaLadunku, double wysokosc, double wagaWlasna, int glebokosc, double maksymalnaMasaLadunku, bool isHazard)
    {
        MasaLadunku = masaLadunku;
        Wysokosc = wysokosc;
        WagaWlasna = wagaWlasna;
        Glebokosc = glebokosc;
        MaksymalnaMasaLadunku = maksymalnaMasaLadunku;
        IsHazard = isHazard;

        GenerateSerialNumber(typ);
    }
    
    public void GenerateSerialNumber(string typ)
    {
        NumerySeryjne = $"KON-{typ}-{count++}";
    }

    public void OproznijKontener()
    {
        MasaLadunku = 0;
    }

    public void ZaladowanieKontenera()
    {
        double maxLoad = IsHazard ? MaksymalnaMasaLadunku * 0.5 : MaksymalnaMasaLadunku * 0.9;
        
        if (MasaLadunku > maxLoad)
        {
            NotifyHazard();
        }
    }

    public void NotifyHazard()
    {
        throw new OverfillException(NumerySeryjne);
    }
}