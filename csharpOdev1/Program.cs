/*ödev 1*/
//Console.Write("Lütfen pozitif Bir sayı giriniz : ");
//int n =Convert.ToInt32(Console.ReadLine());
//int[] numbers = new int[n];
//for(int i = 0; i < n; i++){
//    Console.Write($"Lütfen {i+1}.sayiyi giriniz : ");
//    numbers[i] =Convert.ToInt32(Console.ReadLine()); 
//}
//Console.WriteLine("Girilen çift sayılar");
//foreach (int number in numbers)
//{
//    if(number % 2 == 0){
//        Console.WriteLine(number);
//    }
//}

/*ödev 2*/
//Console.Write("Lütfen pozitif Bir sayı giriniz : n = ");
//int n =Convert.ToInt32(Console.ReadLine());
//Console.Write("Lütfen pozitif Bir sayı giriniz : m = ");
//int m =Convert.ToInt32(Console.ReadLine());
//int[] numbers = new int[n];
//for(int i = 0; i < n; i++){
//    Console.Write($"Lütfen {i+1}.sayiyi giriniz : ");
//    numbers[i] =Convert.ToInt32(Console.ReadLine()); 
//}
//foreach(int number in numbers){
//    if(number % m == 0){
//        Console.WriteLine($"{number} sayısı {m} sayısına eşit veya tam bölünür.");
//    }
//}

/*ödev 3*/
//Console.Write("Lütfen pozitif Bir sayı giriniz : ");
//int n =Convert.ToInt32(Console.ReadLine());
//string[] words =  new string[n];
//for(int i = 0; i < n; i++){
//    Console.Write(i+1 + ". Lütfen bir kelime yazın : ");
//    var a = Console.ReadLine();
//   if( a is not null){
//    words[n-i-1] = a;
//   }
//}
//foreach(string word in words){
//    Console.WriteLine(word);
//}

/*ödev 4*/
Console.Write("Lütfen bir Kelime yazınız : ");
 var a =  Console.ReadLine();
 string word;
 int sayac =0;
 if(a is not null){word = a;}else{word = "";}


for(int i = 0; i< word.Length; i++){
    if(word[i] == ' '){sayac++;}
}

Console.WriteLine($"Harf sayısı : {word.Length-sayac}");
Console.WriteLine($"Kelime sayısı sayısı : {sayac + 1}");