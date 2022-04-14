string degisken =  "ders csharp";
string degisken2 =  "ders";

//lenght
Console.WriteLine(degisken.Length);

//ToUpper - ToLower
Console.WriteLine(degisken.ToLower());
Console.WriteLine(degisken.ToUpper());

//Concant
Console.WriteLine(String.Concat(degisken," Merhaba"));

//Compare, CompareTo -1, 0, 1
Console.WriteLine(degisken.CompareTo(degisken2));
Console.WriteLine(string.Compare(degisken, degisken2, true));
Console.WriteLine(string.Compare(degisken, degisken2, false));

//contains
Console.WriteLine(degisken.Contains(degisken2));
Console.WriteLine(degisken.EndsWith("."));
Console.WriteLine(degisken.StartsWith("m"));

//IndexOf
Console.WriteLine(degisken.IndexOf("cs"));
Console.WriteLine(degisken.IndexOf("fsdf"));
Console.WriteLine(degisken.LastIndexOf("i"));

//Insert
Console.WriteLine(degisken.Insert(0,"ekle"));

//padleft, padright
Console.WriteLine(degisken + degisken2.PadLeft(30));
Console.WriteLine(degisken + degisken2.PadLeft(30,'*'));
Console.WriteLine(degisken + degisken2.PadRight(30));
Console.WriteLine(degisken + degisken2.PadRight(30,'*'));

//remove
Console.WriteLine(degisken.Remove(10));
Console.WriteLine(degisken.Remove(5,3));
Console.WriteLine(degisken.Remove(0,1));

//replace
Console.WriteLine(degisken.Replace("csharp","c#"));
Console.WriteLine(degisken.Replace(" ","*"));

//split
Console.WriteLine(degisken.Split(' ')[1]);

//substring
Console.WriteLine(degisken.Substring(4));
Console.WriteLine(degisken.Substring(4,6));

