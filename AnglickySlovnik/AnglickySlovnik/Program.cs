/*
Dictionary<string, string> Slovnik = new Dictionary<string, string>();
Slovnik.Add("ahoj", "hello");
Slovnik.Add("voda", "water");
Slovnik.Add("džujš", "juice");
Slovnik.Add("auto", "car");


Console.WriteLine("Jake slovo chceš překladat? ");
string answer = Console.ReadLine();

if (!Slovnik.ContainsKey(answer)) { Console.WriteLine("to slovo neznam"); return; }

Console.WriteLine($"slovo {answer} ve angličtině je {Slovnik[answer]}");
*/

List<string> ceskySlovnik = new List<string>()
{
    "ahoj",
    "voda",
    "džujš",
    "auto"
};
List<string> anglickySlovnik = new List<string>()
{
    "hello",
    "water",
    "juice",
    "car"
};
Console.WriteLine("Jake slovo chceš překladat? ");
string answer = Console.ReadLine();

if (!ceskySlovnik.Contains(answer)) { Console.WriteLine("to slovo neznam"); return; }

Console.WriteLine($"slovo {answer} ve angličtině je {anglickySlovnik[ceskySlovnik.IndexOf(answer)]}");