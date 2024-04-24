using System;

public class Lucistnik
{
    public int PocetSipu = 10;

    public void Vystrel()
    {
        for (int i = PocetSipu; i > 0; i--)
        {
            Console.WriteLine("Vzdy se trefim primo doprostred!");
            PocetSipu--; // Snížení počtu šípů po každém výstřelu
        }

        if (PocetSipu == 0)
        {
            Console.WriteLine("Nemam sipy.");
        }
    }
}

