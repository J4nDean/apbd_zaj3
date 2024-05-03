using ConsoleApp1;

public class ContainerTests
{
    public void TestLiquidContainer()
    {
        var liquidContainer = new LiquidContainer("L", 100, 200, 50, 100, 500, false);
        liquidContainer.ZaladowanieKontenera(400);
        liquidContainer.WypiszInformacje(); 

        if (liquidContainer.PobierzMaseLadunku() != 400)
        {
            Console.WriteLine("TestLiquidContainer failed: MasaLadunku is not correct.");
        }
        liquidContainer.OproznijKontener();
        liquidContainer.WypiszInformacje(); 

        if (liquidContainer.PobierzMaseLadunku() != 0)
        {
            Console.WriteLine("TestLiquidContainer failed: MasaLadunku is not correct after OproznijKontener.");
        }
    }

    public void TestGasContainer()
    {
        var gasContainer = new GasContainer("G", 100, 200, 50, 100, 500, 1);
        gasContainer.ZaladowanieKontenera(400);
        gasContainer.WypiszInformacje(); 

        if (gasContainer.PobierzMaseLadunku() != 400)
        {
            Console.WriteLine("TestGasContainer failed: MasaLadunku is not correct.");
        }
        gasContainer.OproznijKontener();
        gasContainer.WypiszInformacje(); 

        if (gasContainer.PobierzMaseLadunku() != 20) 
        {
            Console.WriteLine("TestGasContainer failed: MasaLadunku is not correct after OproznijKontener.");
        }
    }

    public void TestCoolerContainer()
    {
        var coolerContainer = new CoolerContainer("C", 100, 200, 50, 100, 500, -10);
        coolerContainer.ZaladowanieKontenera("milk", -5);
        coolerContainer.WypiszInformacje(); 

        if (coolerContainer.RodzajProduktu != "milk" || coolerContainer.PobierzMaseLadunku() != 500 || coolerContainer.TemperaturaProduktu != -5)
        {
            Console.WriteLine("TestCoolerContainer failed: RodzajProduktu, MasaLadunku or TemperaturaProduktu is not correct.");
        }
        coolerContainer.OproznijKontener();
        coolerContainer.WypiszInformacje(); 

        if (coolerContainer.PobierzMaseLadunku() != 0 || coolerContainer.RodzajProduktu != "Brak")
        {
            Console.WriteLine("TestCoolerContainer failed: MasaLadunku or RodzajProduktu is not correct after OproznijKontener.");
        }
    }
}