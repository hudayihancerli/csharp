Console.WriteLine("Lütfen bir sayı giriniz.");
int a =Convert.ToInt32(Console.ReadLine());

for (int i = 1; i<a; i++)
{
    if(i%2==0){
        Console.WriteLine($"{i} sayısı çifttir.");
    }else{
        Console.WriteLine($"{i} sayısı tektir.");
    }
}
  int tek = 0, cift = 0;
for(int j = 0; j<=1000; j++){
  

    if(j%2==0){
        cift += j;
    }else{
        tek += j;
    }

    
}Console.WriteLine($"Tek toplam : {tek}");
    Console.WriteLine($"Çift toplam : {cift}");