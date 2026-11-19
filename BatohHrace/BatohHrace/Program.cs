
List<string> batoh = new List<string>();
for (int i = 0; i < 3; i++)
{
    Console.Write("Co chceš vložit do batohu? ");
    string answer = Console.ReadLine();
    batoh.Add(answer);
}

Console.WriteLine($"{batoh.Count}");