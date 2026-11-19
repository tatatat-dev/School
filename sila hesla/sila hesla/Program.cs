
int skore = 3;
Console.Write("Napište vaše heslo: ");
string heslo = Console.ReadLine();
int delka = heslo.Length;
if (delka < 8) skore -= 1;
string[] zakazaneHesla = {"123456", "heslo", "admin" };
for (int i = 0; i < zakazaneHesla.Length; i++)
{
    if (heslo == zakazaneHesla[i]) skore -= 1;
}
bool jeSpecZnak = false;

for (int i = 0; i < heslo.Length; i++)
{
    char pismeno = heslo[i];
    if (pismeno == '@' || pismeno == '1' || pismeno == '!' || pismeno == '#') jeSpecZnak = true;
}
if (jeSpecZnak == false) skore -= 1;
Console.WriteLine($"skore vašeho hesla je {skore}");

