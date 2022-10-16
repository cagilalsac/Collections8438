IDictionary<string, string> sozluk = new Dictionary<string, string>()
{
    {
        "table", "masa"
    },
    {
        "computer", "bilgisayar"
    }
};
sozluk.Add(new KeyValuePair<string, string>("phone", "telefon"));
sozluk.Add("car", "araba");

Console.WriteLine(sozluk["car"]); // araba

foreach (var eleman in sozluk)
{
    Console.WriteLine(eleman);
}

foreach (var eleman in sozluk)
{
    Console.WriteLine(eleman.Key + ": " + eleman.Value);
}

Dictionary<int, Hayvan> hayvanlar = new Dictionary<int, Hayvan>()
{
    { 1, new Hayvan() { Adi = "Leo", Cinsi = "Köpek" } },
    { 2, new Hayvan() { Adi = "Garfield", Cinsi = "Kedi" } }
};
Console.WriteLine(hayvanlar[1].Adi + " " + hayvanlar[1].Cinsi);

foreach (var hayvan in hayvanlar)
{
    Console.WriteLine(hayvan.Key + ": " + hayvan.Value.Adi + " (" + hayvan.Value.Cinsi + ")");
}

class Hayvan
{
    public string Adi { get; set; }
    public string Cinsi { get; set; }
}
