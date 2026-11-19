Random rng = new Random();
List<int> cisla = new List<int>();
int nahodnychCisel = 10;

NaplnSeznam();
VypisSeznam();
Vyskyt(3);

void VypisSeznam()
{
    for (int i = 0; i < cisla.Count; i++)
    {
        Console.Write($"{cisla[i]} ");
    }
}
void NaplnSeznam()
{
    cisla.Clear();
    for (int i = 0; i < nahodnychCisel; i++)
    {
        cisla.Add(rng.Next(0, 5));
    }
}

void Vyskyt(int hledanaHodnota)
{
    int vyskytuje = 0;
    for (int i = 0;i < cisla.Count;i++)
    {
        if (cisla[i] == hledanaHodnota)
        {
            vyskytuje++;
        }
    }
    Console.WriteLine($"počet vyskytu cisla {hledanaHodnota} je {vyskytuje}");
}