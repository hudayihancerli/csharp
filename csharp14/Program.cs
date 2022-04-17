Calisan calisan1 = new Calisan("a", "b");
calisan1.CalisanBilgileri();

class Calisan{
    public string ad;
    public string soyad;

    public Calisan(string ad, string soyad){
        this.ad = ad;
        this.soyad = soyad;
    }

    public void CalisanBilgileri(){
        Console.WriteLine($"ad : {ad}");
        Console.WriteLine($"soyad : {soyad}");
    }
}