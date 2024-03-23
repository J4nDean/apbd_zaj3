namespace ConsoleApp1;

public class Program
{
    public static void Main(string[] args)
    {
        

        CoolerContainer coolerContainer = new CoolerContainer("C", 100, 100, 100, 100, 1000, 20);
        coolerContainer.ZaladowanieKontenera("Mleko", 10);
        Console.Write(coolerContainer.RodzajProduktu + "\n");
        Console.Write(coolerContainer.MasaLadunku + "\n");
        coolerContainer.OproznijKontener();
        Console.Write(coolerContainer.RodzajProduktu + "\n");
        Console.Write(coolerContainer.MasaLadunku + "\n");
        Console.Write(coolerContainer.NumerySeryjne + "\n");


        
    }
}