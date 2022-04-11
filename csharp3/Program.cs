int[] rakamlar = new int[9];

string[] hayvanlar = {"kedi", "köpek", "kedi balığı", "köpekbalığı"};

rakamlar[0] = 8;
hayvanlar[0] = "maymun";

foreach (var rakam in rakamlar)
{
    Console.WriteLine(rakam);
}


Console.WriteLine("Lütfen bir sayı giriniz");
int number =Convert.ToInt32(Console.ReadLine());
int[] arr = new int[number];
for(int i = 0; i < number; i++){
    Console.Write($"{i+1}. sayıyı giriniz : ");
    arr[i] = Convert.ToInt32(Console.ReadLine());
}

foreach (var num in arr)
{
    
    Console.WriteLine(num);
}