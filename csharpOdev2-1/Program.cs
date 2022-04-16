using System;
using System.Collections;
using System.Collections.Generic;

int num = 0;
ArrayList arrayList = new ArrayList();

Console.WriteLine("20 tae pozitif sayı giriniz.");
int count = 0;

while(count < 20){
    Console.Write($"{count + 1}. sayı : ");
    try
    {
        num = int.Parse(Console.ReadLine());
        if(num > 0){
            count++;
            arrayList.Add(num);
        }
    }
    catch (System.Exception)
    {
        
        throw;
    }
}

ArrayList asal = new ArrayList();
ArrayList asalOlmayan = new ArrayList();

bool statu = false;

foreach(int number in arrayList){
    statu = false;

    for(int i = 2; i <= number / 2;i++){
        if(number % i == 0){
            statu = true;
            break;
        }
    }
    if(statu == true || number ==1){
        asalOlmayan.Add(number);
    }else{
        asal.Add(number);
    }

    int ort = 0;
    asal.Sort();
    foreach (int item in asal)
    {
        ort += item;
        
    }

    Console.WriteLine(ort/asal.Count);

    ort = 0;
    asalOlmayan.Sort();
    foreach (int item in asal)
    {
        ort += item;
        
    }

    Console.WriteLine(ort/asalOlmayan.Count);
}