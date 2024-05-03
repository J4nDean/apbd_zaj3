using ConsoleApp1;

public class KontenerowiecTests
{
    public void TestDodajKontener()
    {
        var kontenerowiec = new Kontenerowiec
        {
            MaksymalnaIloscKontenerow = 10,
            MaksymalnaWagaKontenerow = 1000
        };

        var liquidContainer = new LiquidContainer("L", 100, 200, 50, 100, 500, false);

        kontenerowiec.DodajKontener(liquidContainer);

        kontenerowiec.WypiszInformacje(); // Wywołanie metody WypiszInformacje()

        if (kontenerowiec.Kontenery.Count != 1)
        {
            Console.WriteLine("TestDodajKontener failed: Kontenery.Count is not correct.");
        }
        if (kontenerowiec.ObliczWageKontenerow() != 100)
        {
            Console.WriteLine("TestDodajKontener failed: ObliczWageKontenerow is not correct.");
        }
    }

    public void TestUsunKontener()
    {
        var kontenerowiec = new Kontenerowiec
        {
            MaksymalnaIloscKontenerow = 10,
            MaksymalnaWagaKontenerow = 1000
        };

        var liquidContainer = new LiquidContainer("L", 100, 200, 50, 100, 500, false);

        kontenerowiec.DodajKontener(liquidContainer);
        kontenerowiec.WypiszInformacje(); 

        kontenerowiec.UsunKontener(liquidContainer);
        kontenerowiec.WypiszInformacje(); 
        if (kontenerowiec.Kontenery.Count != 0)
        {
            Console.WriteLine("TestUsunKontener failed: Kontenery.Count is not correct.");
        }
    }

    public void TestObliczWageKontenerow()
    {
        var kontenerowiec = new Kontenerowiec
        {
            MaksymalnaIloscKontenerow = 10,
            MaksymalnaWagaKontenerow = 1000
        };

        var liquidContainer1 = new LiquidContainer("L", 100, 200, 50, 100, 500, false);
        var liquidContainer2 = new LiquidContainer("L", 200, 200, 50, 100, 500, false);

        kontenerowiec.DodajKontener(liquidContainer1);
        kontenerowiec.WypiszInformacje(); 

        kontenerowiec.DodajKontener(liquidContainer2);
        kontenerowiec.WypiszInformacje();

        if (kontenerowiec.ObliczWageKontenerow() != 300)
        {
            Console.WriteLine("TestObliczWageKontenerow failed: ObliczWageKontenerow is not correct.");
        }
    }
}