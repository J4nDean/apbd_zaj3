namespace ConsoleApp1;

public class Kontenerowiec
{
    public List<IContainerBase> Kontenery { get; set; }
    public double MaksymalnaPredkosc { get; set; }
    public int MaksymalnaIloscKontenerow { get; set; }
    public double MaksymalnaWagaKontenerow { get; set; } 
    

    public Kontenerowiec()
    {
        Kontenery = new List<IContainerBase>();
    }
    
    
    public void DodajKontener(IContainerBase kontener)
    {
        if (Kontenery.Count < MaksymalnaIloscKontenerow && ObliczWageKontenerow() + kontener.MasaLadunku <= MaksymalnaWagaKontenerow)
        {
            Kontenery.Add(kontener);
        }
        else
        {
            Console.WriteLine("Nie można dodać kontenera. Przekroczono maksymalną ilość kontenerów lub maksymalną wagę kontenerów.");
        }
    }

    public void UsunKontener(IContainerBase kontener)
    {
        Kontenery.Remove(kontener);
    }

    public void ZastapKontener(int index, IContainerBase nowyKontener)
    {
        if (index >= 0 && index < Kontenery.Count)
        {
            Kontenery[index] = nowyKontener;
        }
        else
        {
            Console.WriteLine("Nie można zastąpić kontenera. Nieprawidłowy indeks.");
        }
    }

    public void PrzeniesKontener(Kontenerowiec docelowyStatek, IContainerBase kontener)
    {
        if (Kontenery.Contains(kontener))
        {
            UsunKontener(kontener);
            docelowyStatek.DodajKontener(kontener);
        }
        else
        {
            Console.WriteLine("Nie można przenieść kontenera. Kontener nie jest na tym statku.");
        }
    }

    public void WypiszInformacje()
    {
        Console.WriteLine($"Maksymalna prędkość: {MaksymalnaPredkosc}, Maksymalna ilość kontenerów: {MaksymalnaIloscKontenerow}, Maksymalna waga kontenerów: {MaksymalnaWagaKontenerow}");
        Console.WriteLine("Kontenery:");
        foreach (var kontener in Kontenery)
        {
            kontener.WypiszInformacje();
        }
    }
    
    public double ObliczWageKontenerow()
    {
        return Kontenery.Sum(k => k.PobierzMaseLadunku());
    }
}