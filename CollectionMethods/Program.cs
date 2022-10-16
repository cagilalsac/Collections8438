Sehir sehir1 = new Sehir()
{
    Id = 1,
    Adi = "Ankara"
};

Sehir sehir2 = new Sehir(2, "İstanbul");

List<Sehir> sehirler = new List<Sehir>();
sehirler.Add(sehir1);
sehirler.Add(sehir2);

Console.WriteLine("Şehir sayısı: " + sehirler.Count);

Console.WriteLine("İlk şehir: " + sehirler[0].Adi + " (" + sehirler[0].Id + ")");

Sehir[] yeniSehirler = new Sehir[2]
{
    new Sehir()
    {
        Id = 3,
        Adi = "Adana"
    },
    new Sehir(4, "Antalya")
};
sehirler.AddRange(yeniSehirler);

IEnumerable<string> names1 = new List<string>()
{
    "Ali", "Veli", "Ayşe"
};
Console.WriteLine(names1.Count());

ICollection<int> numbers1 = new List<int>()
{
    2, 1, 3
};
var names2 = names1.ToList();
names2.Sort();
foreach (string name in names2)
{
    Console.WriteLine(name);
}

if (names2.Contains("Çağıl"))
    Console.WriteLine("Çağıl var");
else
    Console.WriteLine("Çağıl yok");

if (names2.Contains("Ali"))
    Console.WriteLine("Ali var");
else
    Console.WriteLine("Ali yok");
int index = names2.IndexOf("Veli"); // 1
names2.Reverse();

sehirler.Contains(new Sehir(1, "Ankara")); // false
var s = sehirler[0];
sehirler.Contains(s); // true

var seciniz = new Sehir()
{
    Id = -1,
    Adi = "Seçiniz"
};
sehirler.Insert(0, seciniz);
sehirler.Remove(seciniz);

sehirler.Clear();


class Sehir
{
    public int Id { get; set; }
    public string Adi { get; set; }

    public Sehir()
    {
        Id = 0;
        Adi = "";
    }

    public Sehir(int id, string adi)
    {
        Adi = adi;
        Id = id;
    }
}