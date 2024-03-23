using ConsoleApp1.Exceptions;

namespace ConsoleApp1;

public class LiquidContainer : IContainerBase, IHazardNotifier
{
    public double MasaLadunku { get; set; }
    public double Wysokosc { get; set; }
    public double WagaWlasna { get; set; }
    public int Glebokosc { get; set; }
    public string NumerySeryjne { get; }
    public double MaksymalnaMasaLadunku { get; set; }
    public bool IsHazard { get; }
    
    public void GenerateSerialNumber()
    {
        throw new NotImplementedException();
    }

    public void OproznijKontener()
    {
        throw new NotImplementedException();
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