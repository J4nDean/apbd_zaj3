using ConsoleApp1.Exceptions;

namespace ConsoleApp1;

public class GasContainer : IContainerBase, IHazardNotifier
{
    public double MasaLadunku { get; set; }
    public double Wysokosc { get; set; }
    public double WagaWlasna { get; set; }
    public int Glebokosc { get; set; }
    public string NumerySeryjne { get; }
    public double MaksymalnaMasaLadunku { get; set; }
    public double Cisnienie { get; set; }
    
    public void GenerateSerialNumber()
    {
        throw new NotImplementedException();
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