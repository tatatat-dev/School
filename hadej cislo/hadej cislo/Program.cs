Random rng = new Random();
bool chceHrat = true;

while (chceHrat) 
{
    bool uhadnulCislo = false;
    int nahodneCislo = rng.Next(1, 11);
    int pocetPokusu = 0;
    Console.Write("jake cislo jsem myslim? ");
    while (!uhadnulCislo)
    {
        string odpovedHrace = Console.ReadLine();
        pocetPokusu += 1;
        if (!int.TryParse(odpovedHrace, out int cisloHrace))
        {
            Console.Write("HOCHU!!! to neni vtipne, napiš čislo!");
            continue;
        }

        if (cisloHrace == nahodneCislo)
        {
            uhadnulCislo = true;
            continue;
        }
        if (cisloHrace > nahodneCislo)
        {
            Console.Write("menši ");
        }
        else
        {
            Console.Write("větši ");
        }

    }
    Console.WriteLine($"čislo bylo {nahodneCislo}");
    Console.WriteLine($"počet pokusu je {pocetPokusu}");
    Console.Write("chcete hrat ještě? ");
    string odpoved = Console.ReadLine();
    if (odpoved == "ano")
    {
        chceHrat = true;
    }
    else
    {
        chceHrat = false;
    }
}
