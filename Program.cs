using ConsoleApp1;
using System.Text;
using System.Linq;


List<Triatlon> Triatlon_list = new List<Triatlon>();

var sr = new StreamReader(@"forras.txt", Encoding.UTF8);

while (!sr.EndOfStream)
{
    string[] sor = sr.ReadLine()!.Split(";");

    Triatlon triatlon = new Triatlon();

    triatlon.Nev = sor[0];
    triatlon.Kor = int.Parse(sor[1]);
    triatlon.Rajtsz = int.Parse(sor[2]);
    triatlon.Nem = sor[3];
    triatlon.Eletkorkateg = sor[4];


    Triatlon_list.Add(triatlon);


}
sr.Close();

Console.WriteLine($" {Triatlon_list.Count} versenyző fejezte be a versenyt");

Console.WriteLine("-----------------------------------------");
double atlagferfikor = Triatlon_list.Where(ferfi => ferfi.Nem == "f").Average(ferfi => 2024 - ferfi.Kor);
Console.WriteLine($" Átlagférfi kor: {atlagferfikor} ");


Console.WriteLine("-----------------------------------------");
int elit = Triatlon_list.Where(elitek => elitek.Eletkorkateg == "elit junior").Count();
Console.WriteLine($" {elit} elit junior versenyző van");

Console.WriteLine("-----------------------------------------");




;