namespace ConsoleApp1;

public class CoolerContainer : IContainerBase, IHazardNotifier
{
    public double MasaLadunku { get; set; }
    public double Wysokosc { get; set; }
    public double WagaWlasna { get; set; }
    public int Glebokosc { get; set; }
    public string NumerySeryjne { get; }
    public double MaksymalnaMasaLadunku { get; set; }
    public double Temperatura { get; set; }
    public string RodzajProduktu { get; set; }
    
    
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
        throw new NotImplementedException();
    }

    public void NotifyHazard()
    {
        throw new NotImplementedException();
    }
}