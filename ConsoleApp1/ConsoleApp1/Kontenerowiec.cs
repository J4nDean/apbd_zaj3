﻿namespace ConsoleApp1;

public class Kontenerowiec
{
    public List<IContainerBase> Kontenery { get; set; }
    public double MaksymalnaPredkosc { get; set; }

    public int MaksymalnaIloscKontenerow { get; set; }

    public Kontenerowiec()
    {
        Kontenery = new List<IContainerBase>();
    }

    public double MaksymalnaWagaKontenerow()
    {
        return Kontenery.Sum(k => k.MaksymalnaMasaLadunku);
    }
}