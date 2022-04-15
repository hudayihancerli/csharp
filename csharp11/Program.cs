//System.Collections

using System.Collections;

ArrayList liste = new ArrayList();
liste.Add("a");
liste.Add(2);
liste.Add(true);
liste.Add('b');

//içerisindeki verilere erişme
Console.WriteLine(liste[1]);
foreach (var item in liste)
{
    Console.Write(item + " ");
}

//AddRange
string[] renkler = {"kırmızı", "sarı", "mavi"};
List<int> sayilar = new List<int>(){1,2,3,4,5};
liste.AddRange(renkler);
liste.AddRange(sayilar);

foreach(var item in liste)
{
    Console.WriteLine(item);
}

//sort
liste.Sort();//hata verebilir.

//Binary search
Console.WriteLine(liste.BinarySearch(9));

//reverse
liste.Reverse();
foreach(var item in liste){
    Console.WriteLine(item);
}

//clear
liste.Clear();

foreach(var item in liste){//liste boş olduğu için birşey yazdırmaz.
    Console.WriteLine(item);
}