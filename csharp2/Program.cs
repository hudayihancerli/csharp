Console.WriteLine("Lütfen bir sayı giriniz.");
int sayi =Convert.ToInt32(Console.ReadLine());
int toplam = 0;
int sayac = 1;
while(sayac <= sayi){
    toplam += sayac;
    sayac++;
}
Console.WriteLine($"toplam = {toplam}, ortalama = {toplam/sayi}");

char alf = 'a';
while(alf < 'z'){
    Console.WriteLine(alf);
    alf++;
}

string[] harfler = {"a","b","c","d","e"};

foreach (var harf in harfler)
{
    Console.WriteLine(harf);
}

