namespace ConsoleApp1;

public abstract class KontenerBase
{
    protected double MasaLadunku { get; set; }
    protected double Wysokosc { get; set; }
    protected double WagaWlasna { get; set; }
    protected int Glebokosc { get; set; }
    protected string NumerySeryjne { get; set; }
    protected double MaksymalnaMasaLadunku { get; set; }
    private static int counter = 0;
    
    public KontenerBase(string rodzaj, double wysokosc, double wagaWlasna, int glebokosc)
    {
        NumerySeryjne = GenerateSerialNumber(rodzaj);
        Wysokosc = wysokosc;
        WagaWlasna = wagaWlasna;
        Glebokosc = glebokosc;
    }
    
    public static string GenerateSerialNumber(string rodzaj)
    {
        counter++;
        return $"KON-{rodzaj}-{counter}";
    }
    
    public static void OproznijKontener(KontenerBase kontener)
    {
        kontener.MasaLadunku = 0;
    }
    
    public static void SetMasaLadunku(KontenerBase kontener)
    {
        Random random = new Random();
        double randomMasaLadunku = random.NextDouble() * kontener.MaksymalnaMasaLadunku;

        if (randomMasaLadunku > kontener.MaksymalnaMasaLadunku)
        {
        }

        kontener.MasaLadunku = randomMasaLadunku;
    }
}

public class OverfillException : Exception
{
    public OverfillException(string message) : base(message)
    {
    }
}
