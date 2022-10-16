using System.Collections;

string[] ogrenciler = new string[3]
{
    "Ali", "Veli", "Can"
};
ogrenciler = new string[4]
{
    "Ali", "Veli", "Can", "Muhittin"
};

ArrayList isimListesi = new ArrayList();
isimListesi.Add("Ali");
isimListesi.Add("Veli");
isimListesi.Add("Can");
isimListesi.Add("Muhittin");

foreach (var isimEleman in isimListesi)
{
    Console.WriteLine(isimEleman);
}

Console.WriteLine(isimListesi[3]);

isimListesi.Add('Ç');
isimListesi.Add(12.3);
isimListesi.Add(true);

foreach (var isimEleman in isimListesi)
{
    Console.WriteLine(isimEleman);
}

List<string> sehirListesi = new List<string>()
{
    "İstanbul"
};
sehirListesi.Add("Ankara");
//sehirListesi.Add(1); // yapılamaz

foreach (var sehirElelman in sehirListesi)
{
    Console.WriteLine(sehirElelman);
}

List<Ogrenci> ogrenciListesi = new List<Ogrenci>()
{
    new Ogrenci()
    {
        Id = 1,
        Adi = "Çağıl",
        Soyadi = "Alsaç"
    },
    new Ogrenci()
    {
        Id = 2,
        Adi = "Leo",
        Soyadi = "Alsaç"
    }
};
ogrenciListesi.Add(new Ogrenci() { Id = 3, Adi = "Muihittin", Soyadi = "Cancan" });
foreach (Ogrenci ogrenciEleman in ogrenciListesi)
{
    Console.WriteLine(ogrenciEleman.Id + " - " + ogrenciEleman.Adi + " " + ogrenciEleman.Soyadi);
}

class Ogrenci
{
    public int Id { get; set; }
    public string Adi { get; set; }
    public string Soyadi { get; set; }
}