using System.IO.Pipes;

int PIN = 1234;
int pokusyNapsatPIN = 3;
bool napsalSpravnyPIN = false;

while (!napsalSpravnyPIN)
{
    Console.Write("Napište vaš PIN: ");
    string NapsanejPIN = Console.ReadLine();
    
    if (!int.TryParse(NapsanejPIN, out int USERPIN))
    {
        pokusyNapsatPIN -= 1;
        Console.WriteLine($"jak si na bankomatu napsal pismena? mate {pokusyNapsatPIN} pokusu napsat PIN");
    }
    else if (USERPIN != PIN)
    {
        pokusyNapsatPIN -= 1;
        Console.WriteLine($"spatny PIN. mate {pokusyNapsatPIN} pokusu napsat PIN");
    }
    if (USERPIN == PIN)
    {
        napsalSpravnyPIN = true;
    }
    if (pokusyNapsatPIN == 0)
    {
        Console.WriteLine("HOCHU!!! volam policajte");
        return;
    }
}

Console.WriteLine("napsali jste spravny PIN");

int zustatek = 5000;
int maximalniLimit = 3000;
bool chcePokracovat = true;

while (chcePokracovat)
{
    Console.Write("kolik chcete vyzvednou peněz?");
    string odpoved = Console.ReadLine();
    if (!int.TryParse(odpoved, out int kolikPenez))
    {
        Console.WriteLine("to neni zabavne, napis CISLAMA kolik chces penez");
    }
    else if (kolikPenez > maximalniLimit)
    {
        Console.WriteLine("nene, maximalni limit je 3000");
    }
    else if (kolikPenez % 100 != 0)
    {
        Console.WriteLine("davame jen stovky, zadajte cislo delitelne 100");
    }
    else if (kolikPenez > zustatek)
    {
        Console.WriteLine("jsi moc chudy proto,mas malo penez na uctu");
    }
    else
    {
        zustatek -= kolikPenez;
        Console.WriteLine($"jste vyzvednuli {kolikPenez}, zustatek je {zustatek}");
    }
    Console.Write("chcete pokracovat? (ano/ne)");
    odpoved = Console.ReadLine();
    if (odpoved == "ano")
    {
        chcePokracovat = true;
    }
    else
    {
        chcePokracovat = false;
    }
}
Console.WriteLine("naschledanou");