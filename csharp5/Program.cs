int a = 2;
int b = 3;

Console.WriteLine(a + b);

int sonuc = a + b;



Console.WriteLine(sonuc);

Metotlar ornek = new Metotlar();
ornek.EkranaYazdir(Convert.ToString(sonuc));

int sonuc2 = ornek.ArttirveTopla(ref a, ref b);
Console.WriteLine(Convert.ToString(sonuc2));
Console.WriteLine(Convert.ToString(a + b));



class Metotlar{
    public void EkranaYazdir(string veri){
        Console.WriteLine(veri);
    }

    public int ArttirveTopla(ref int deger1, ref int deger2){
        deger1 += 1;
        deger2 += 2;
        return deger1 + deger2;
    }
}