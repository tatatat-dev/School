using System.Runtime.InteropServices.JavaScript;

List<int> topSkore = new List<int>
{
    100,
    67,
    40
};
Console.WriteLine("Jaký skore máš?");
string answer = Console.ReadLine();

if(!int.TryParse(answer, out int userSkore ))
{
    Console.WriteLine("jdi do haje");
    return;
}

for (int i = 0;  i < topSkore.Count; i++)
{
    if (userSkore > topSkore[i])
    {
        topSkore.Insert(i, userSkore);
        topSkore.RemoveAt(3);
        break;
    }
}

for (int i = 0;i < topSkore.Count;i++)
{
    Console.WriteLine(topSkore[i]);
}
if (topSkore[0] == userSkore)
{
    Console.WriteLine("jsi prvni!");
}
if (!topSkore.Contains(userSkore))
{
    Console.WriteLine("skill issue");
}