Random rng = new Random();
List<int> cisla = new List<int>();
int nahodnychCisel = 100000;

NaplnSeznam();
NejvetsiCislo();
NejmensiCislo();
Prumer();
void NaplnSeznam()
{
    cisla.Clear();
    for (int i = 0; i < nahodnychCisel; i++)
    {
        cisla.Add(rng.Next(0, 21));
    }
}

void NejvetsiCislo()
{
    int nejvetsiCislo = 0;
    for (int i = 0; i < cisla.Count; i++)
    {
        if (cisla[i] > nejvetsiCislo)
        {
            nejvetsiCislo = cisla[i];
        }
    }
    Console.WriteLine(nejvetsiCislo);
}
void NejmensiCislo()
{
    int nejmensiCislo = 20;
    for (int i = 0; i < cisla.Count; i++)
    {
        if (cisla[i] < nejmensiCislo)
        {
            nejmensiCislo = cisla[i];
        }
    }
    Console.WriteLine(nejmensiCislo);
}

void Prumer()
{
    float suma = 0f;
    for (int i = 0;i < cisla.Count;i++ )
    {
        suma += cisla[i];
    }
    suma = suma / cisla.Count;
    Console.WriteLine(suma);
}