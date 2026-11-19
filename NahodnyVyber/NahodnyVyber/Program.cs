Random rng = new Random();
List<int> cisla = new List<int>
{
    67,
    14,
    55,
    87,
    23,
    59
};

Console.Write("Vylosované čislo je");

for(int i = 0; i < 3; i++)
{
    Console.Write(".");
    Thread.Sleep(1000);
}

Console.WriteLine($" {cisla[rng.Next(0, cisla.Count)]}!");