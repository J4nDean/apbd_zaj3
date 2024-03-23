using ConsoleApp1.Exceptions;

namespace ConsoleApp1;

public class GasContainer : IContainerBase, IHazardNotifier
{
    public double MasaLadunku { get; set; }
    public double Wysokosc { get; set; }
    public double WagaWlasna { get; set; }
    public int Glebokosc { get; set; }
    public string NumerySeryjne { get; set; }
    public double MaksymalnaMasaLadunku { get; set; }
    public static int count { get; set; }
    public double Cisnienie { get; set; }
    
    public GasContainer(string typ, double masaLadunku, double wysokosc, double wagaWlasna, int glebokosc, double maksymalnaMasaLadunku, double cisnienie)
    {
        MasaLadunku = masaLadunku;
        Wysokosc = wysokosc;
        WagaWlasna = wagaWlasna;
        Glebokosc = glebokosc;
        MaksymalnaMasaLadunku = maksymalnaMasaLadunku;
        Cisnienie = cisnienie;

        GenerateSerialNumber(typ);
    }
    
    public void GenerateSerialNumber(string typ)
    {
        NumerySeryjne = $"KON-{typ}-{count++}";
    }

    public void OproznijKontener()
    {
        MasaLadunku *= 0.05;
    }

    public void ZaladowanieKontenera()
    {
        if (MasaLadunku > MaksymalnaMasaLadunku)
        {
            NotifyHazard();
        }
    }

    public void NotifyHazard()
    {
        throw new OverfillException(NumerySeryjne);
    }
}