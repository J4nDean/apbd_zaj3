namespace ConsoleApp1;

public interface IContainerBase
{
    protected double MasaLadunku { get; set; }
    protected double Wysokosc { get; set; }
    protected double WagaWlasna { get; set; }
    protected int Glebokosc { get; set; }
    protected string NumerySeryjne { get; }
    public double MaksymalnaMasaLadunku { get; set; }
    

    void GenerateSerialNumber();
    void OproznijKontener();
    void ZaladowanieKontenera();
}
