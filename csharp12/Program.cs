using System.Collections.Generic;

//dictionary

Dictionary<int,string> kullacilar = new Dictionary<int, string>();

kullacilar.Add(10,"on");//key, value
kullacilar.Add(12,"oniki");
kullacilar.Add(18,"onsekiz");
kullacilar.Add(20,"yirmi");

//dizinin elemanlarına erişim
Console.WriteLine(kullacilar[12]);
foreach(var item in kullacilar){
    Console.WriteLine(item); //item.value
}

//count
Console.WriteLine(kullacilar.Count);

//Contains
Console.WriteLine(kullacilar.ContainsKey(12));//var mı?
Console.WriteLine(kullacilar.ContainsValue("yok"));//var mı?


