Ogrenci ogrenci = new Ogrenci();
ogrenci.Ad = "a";
ogrenci.Soyad = "b";

ogrenci.getir();


class Ogrenci{
    private string ad;
    private string soyad;

    public string Ad { get; set; }
    public string Soyad { get; set; }

    public Ogrenci(string ad, string soyad){
        this.Ad = ad;
        this.Soyad = soyad;
    } 

    public Ogrenci(){
        Console.WriteLine("boş");
    }

    public void getir(){
        Console.WriteLine("Öğrenci bilgileri : ");
        Console.WriteLine("Adı : {0}",this.ad);
        Console.WriteLine("Soyadı : {0}",this.soyad);
    }

}