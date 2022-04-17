
Console.WriteLine(Calisan.CalisanSayisi);
Calisan calisan1 = new Calisan("a","b");
Console.WriteLine(Calisan.CalisanSayisi);



class Calisan{
    private static int calisanSayisi;

    public static int CalisanSayisi {get => calisanSayisi;}

    private string ad;
    private string soyad;

    static Calisan(){
        calisanSayisi = 0;
    }

    public Calisan(string ad, string soyad){
        this.ad = ad;
        this.soyad = ad;
        calisanSayisi++;
    }
}