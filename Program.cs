// See https://aka.ms/new-console-template for more information

partial class Program
{
    static void Main(string[] args)
    {
        Lucistnik lucistnik = new Lucistnik();
        lucistnik.Vystrel();

        bool jeCisloPlatne = false;
        double cislo1 = 0;
        bool jeCislo2Platne = false;
        double cislo2 = 0;

        Console.WriteLine("Zadej prvni cislo:");
        string cislo1text = Console.ReadLine();
        jeCisloPlatne = double.TryParse(cislo1text, out cislo1);


        Console.WriteLine("Zadej druhe cislo:");
        string cislo2text = Console.ReadLine();
        jeCislo2Platne = double.TryParse(cislo2text, out cislo2);

        double vysledek;
        vysledek = cislo1 + cislo2;
        Console.WriteLine($"Výsledek je {cislo1} + {cislo2} = {vysledek}.");
   
    int pocetHvezd = 0;
    bool jePocetHvezdPlatny = false;
    Console.WriteLine("Zadej počet hvězdiček:");
    string pocetHvezdicekText = Console.ReadLine();
    jePocetHvezdPlatny = int.TryParse(pocetHvezdicekText, out pocetHvezd);

        for (int i = 1; i <= pocetHvezd; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("*"); // Vypsání hvězdičky
            }
            Console.WriteLine();
        }

        Random generator = new Random();
        int nahodneCislo = generator.Next(11);
        int pokusy = 3;

        Console.WriteLine("Myslím si číslo od 0 do 10, hádejte!");

        while (pokusy > 0)
        {
            Console.Write("Zadejte vaši hádanou hodnotu: ");
            int hadaneCislo = int.Parse(Console.ReadLine());

            if (hadaneCislo == nahodneCislo)
            {
                Console.WriteLine("Gratuluji, uhodli jste správně!");
                return;
            }
            else
            {
                pokusy--;
                if (pokusy > 0)
                {
                    Console.WriteLine("Špatně! Zbývá vám ještě " + pokusy + " pokusů.");
                }
                else
                {
                    Console.WriteLine("Bohužel, neuhodli jste. Myslel jsem si číslo " + nahodneCislo + ".");
                }
            }
        }
    }
}

