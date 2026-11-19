Random rng = new Random();

List<int> seznam = new List<int>();
List<int> unikatniSeznam = new List<int>();

NaplnSeznam(15,5);
VytvorUnikatniSeznam();
VypisUnikatniSeznam();

void NaplnSeznam(int pocet, int maxHodnota)
{
    for (int i = 0; i < pocet; i++)
    {
        seznam.Add(rng.Next(0, maxHodnota + 1));
    }
}

void VytvorUnikatniSeznam()
{
    for (int i = 0; i < seznam.Count; i++)
    {
        if (!unikatniSeznam.Contains(seznam[i]))
        {
            unikatniSeznam.Add(seznam[i]);
        }
    }
}

void VypisUnikatniSeznam()
{
    for(int i = 0;i < unikatniSeznam.Count;i++ )
    {
        Console.Write(unikatniSeznam[i]);
    }
}