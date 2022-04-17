//class sözdizimi
//class sinifAdi 
//{
    //erişim belirleyici veri tiği özellik adı
    //erişim belirleyici geri dönüş tiği method adI(parametre listesi)
    //{
        //method komutları
    //}
//}

//erişim belrleyiciler
// public, private, ınternal, protected
 Calisan calisan1 = new Calisan();
    calisan1.Ad = "a";
    calisan1.Soyad = "b";
    calisan1.No = 123;
    calisan1.Departman = "ik";
    calisan1.CalisanBilgileri();
    
class Calisan{
    public string Ad;
    public string Soyad;
    public int No;
    public string Departman;
    
   

    public void CalisanBilgileri(){
        Console.WriteLine("Çalışan adı {0}",Ad);
        Console.WriteLine("Çalışan Soyad {0}",Soyad);
        Console.WriteLine("Çalışan No {0}",No);
        Console.WriteLine("Çalışan Departman {0}",Departman);
    }
}