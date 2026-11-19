
List<string> vipHoste = new List<string>
{
    "Petr",
    "Jana",
    "Hubert",
    "Tereza"
};
Console.Write("Jak se jmenuješ? ");
string answer = Console.ReadLine();
bool isHeInList = false;

for (int i = 0; i < vipHoste.Count; i++)
{
    if (answer == vipHoste[i])
    {
        isHeInList = true;
        break;
    }
}
if (!isHeInList)
{
    Console.WriteLine("Hochu, get out");
    return;
}
Console.WriteLine("mužeš jit");
