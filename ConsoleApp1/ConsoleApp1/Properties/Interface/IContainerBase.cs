namespace ConsoleApp1;

public interface IContainerBase
{
    public double MasaLadunku { get; set; }
    protected double Wysokosc { get; set; }
    protected double WagaWlasna { get; set; }
    protected int Glebokosc { get; set; }
    protected string NumerySeryjne { get; }
    protected double MaksymalnaMasaLadunku { get; set; }
    protected static int count = 0;
    

    void GenerateSerialNumber(string typ);
    void OproznijKontener();
    void ZaladowanieKontenera(int masaLadunku);
    void WypiszInformacje();
    double PobierzMaseLadunku();
}
