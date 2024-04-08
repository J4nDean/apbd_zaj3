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

    public LiquidContainer(string typ, double masaLadunku, double wysokosc, double wagaWlasna, int glebokosc,
        double maksymalnaMasaLadunku, bool isHazard)
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



    public void ZaladowanieKontenera(int masaLadunku)
    {
        double maxLoad = IsHazard ? MaksymalnaMasaLadunku * 0.5 : MaksymalnaMasaLadunku * 0.9;
        MasaLadunku = masaLadunku;

        if (MasaLadunku > maxLoad)
        {
            NotifyHazard(NumerySeryjne);
        }
    }

    public void NotifyHazard(string containerNumber)
    {
        Console.WriteLine($"Niebezpieczna operacja na kontenerze {containerNumber}!");
    }
}   