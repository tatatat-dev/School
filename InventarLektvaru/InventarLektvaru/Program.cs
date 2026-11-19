List<string> lektvary = new List<string> 
{
    "Lečivý lektvar",
    "Lektvar sily",
    "Lektvar neviditelnosti",
    "Mana Lektvar",
};

while (true)
{
    if (Console.ReadKey().Key != ConsoleKey.Spacebar) continue;
    if (lektvary.Count == 0) 
    {
        Console.WriteLine("Nemaš žadne lektvary!");
        continue;
    }
    Console.WriteLine($"vypil jsi {lektvary[0]}");
    lektvary.RemoveAt(0);
}

