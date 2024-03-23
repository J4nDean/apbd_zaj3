using ConsoleApp1.Exceptions;

namespace ConsoleApp1;

public class CoolerContainer : IContainerBase, IHazardNotifier
{
    public double MasaLadunku { get; set; }
    public double Wysokosc { get; set; }
    public double WagaWlasna { get; set; }
    public int Glebokosc { get; set; }
    public string NumerySeryjne { get; set; }
    public double MaksymalnaMasaLadunku { get; set; }
    public static int Count { get; set; }
    public double Temperatura { get; set; }
    public string RodzajProduktu { get; set; }
    public double TemperaturaProduktu { get; set; }

    public CoolerContainer(string typ, double masaLadunku, double wysokosc, double wagaWlasna, int glebokosc,
        double maksymalnaMasaLadunku, double temperatura)
    {
        MasaLadunku = masaLadunku;
        Wysokosc = wysokosc;
        WagaWlasna = wagaWlasna;
        Glebokosc = glebokosc;
        MaksymalnaMasaLadunku = maksymalnaMasaLadunku;
        Temperatura = temperatura;

        GenerateSerialNumber(typ);
    }
    
    public void GenerateSerialNumber(string typ)
    {
        NumerySeryjne = $"KON-{typ}-{Count++}";
    }
    
    public void OproznijKontener()
    {
        MasaLadunku = 0;
        RodzajProduktu = "Brak";
    }

    public void ZaladowanieKontenera()
    {
    }

    public void ZaladowanieKontenera(string produkt, double temperaturaProduktu)
    {
        // Przypisanie wartości do właściwości kontenera
        RodzajProduktu = produkt;
        MasaLadunku = MaksymalnaMasaLadunku;
        TemperaturaProduktu = temperaturaProduktu;

        // Sprawdzenie, czy temperatura produktu jest zgodna z temperaturą kontenera
        if (temperaturaProduktu != Temperatura)
            NotifyHazard();

    }

    public void NotifyHazard()
    {
        throw new InconsistentTempException(NumerySeryjne, TemperaturaProduktu,Temperatura);
    }
}