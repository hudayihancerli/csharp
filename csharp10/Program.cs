//List<T> class
// System.Collections.Generic;
// T -> object türündedir. 

List<int>  sayiListesi = new List<int>();

sayiListesi.Add(23);  
sayiListesi.Add(10);  
sayiListesi.Add(4);  
sayiListesi.Add(5);  
sayiListesi.Add(92);  
sayiListesi.Add(34);  

List<string> renkListesi = new List<string>();

renkListesi.Add("kırmızı");
renkListesi.Add("mavi");
renkListesi.Add("turuncu");
renkListesi.Add("sarı");
renkListesi.Add("yeşil");

//Count
Console.WriteLine(sayiListesi.Count);
Console.WriteLine(renkListesi.Count);

//foreach ve list.foreach ile elemanlara erişim
foreach(int sayi in sayiListesi){
    Console.Write(sayi + " ");
}

foreach (string renk in renkListesi)
{
    Console.Write(renk + " ");
}

sayiListesi.ForEach(sayi => Console.Write(sayi + " "));

//Listeden eleman çıkarma
sayiListesi.Remove(4);
renkListesi.Remove("yeşil");
sayiListesi.RemoveAt(0);//index
renkListesi.RemoveAt(1);//index

//liste içerisinde arama
if(sayiListesi.Contains(10)){
    Console.WriteLine("10 Liste içerisinde bulundu.");
}

//Eleman ile index'e erişme
renkListesi.BinarySearch("sarı");

//Diziyi list'e çevirme
string[] hayvanlarArr = {"kedi", "köpek", "kuş"};
List<string> hayvanlarList = new List<string>(hayvanlarArr);

//Listeyi temizleme
hayvanlarList.Clear();

//List içerisinde nesne tutmak
List<Kullanicilar> kullaniciListesi = new List<Kullanicilar>();
Kullanicilar kullanici1 = new Kullanicilar();
kullanici1.Isim = "a";
kullanici1.Soyisim = "b";
kullanici1.Yas = 21;

Kullanicilar kullanici2 = new Kullanicilar();
kullanici2.Isim = "c";
kullanici2.Soyisim = "d";
kullanici2.Yas = 42;

kullaniciListesi.Add(kullanici1);
kullaniciListesi.Add(kullanici2);

List<Kullanicilar> yeniListe = new List<Kullanicilar>();
yeniListe.Add(new Kullanicilar(){
    Isim = "x",
    Soyisim = "y",
    Yas = 66
});


foreach( var k in kullaniciListesi){
    Console.WriteLine("kullanici Adı: " + k.Isim);
    Console.WriteLine("kullanici Soyadı: " + k.Soyisim);
    Console.WriteLine("kullanici yas: " + k.Yas);
}

public class Kullanicilar{
    private string isim;
    private string soyisim;
    private int yas;
    public string Isim {get => isim; set => isim = value;}
    public string Soyisim {get => soyisim; set => soyisim = value;}
    public int Yas {get => yas; set => yas = value;}

}