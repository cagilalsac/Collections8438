List<int> sayilar = new List<int>();
Console.Write("Sayı: (ç: çıkış) ");
string giris = Console.ReadLine();
bool sonuc;
int sayi;
while (giris != "ç")
{
    sonuc = int.TryParse(giris, out sayi);
    if (sonuc)
    {
        sayilar.Add(sayi);
    }
    Console.Write("Sayı: (ç: çıkış) ");
    giris = Console.ReadLine();
}
foreach (var sa in sayilar)
{
    Console.WriteLine(sa);
}



int s = 10;
BesYap(s);
//Console.WriteLine(s);//10

// hem out hem ref ile değer üzerinden değil de referans üzerinden hafıza adresindeki
// değerin methodda güncellenmesi sağlanır, dolayısıyla method içindeki 
// değişiklik methodun çağrıldığı yere (dışarı) yansır.
int y;
BesYapOut(out y); // out parametre kullanımında ilk değer atamasına gerek yok
//Console.WriteLine(y); // 5

int z = 0;
BesYapRef(ref z); // ref parametre kullanımında z değişkeninin ilk değeri atanmalı
//Console.WriteLine(z); // 5

void BesYap(int sayi)
{
    sayi = 5;
}

void BesYapOut(out int sayi)
{
    sayi = 5;
}

void BesYapRef(ref int sayi)
{
    sayi = 5;
}
