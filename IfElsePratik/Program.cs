// See https://aka.ms/new-console-template for more information
Console.Write("Lütfen bir sayı giriniz!");
int sayi = Convert.ToInt32(Console.ReadLine());
if (sayi > 10)
{
    Console.WriteLine("Girilen sayı 10'dan büyüktür");
}
else if(sayi < 10){
    Console.WriteLine("Girilen sayı 10'dan küçüktür");
}
else
{
    Console.WriteLine("Girilen sayı 10'a eşittir");
}

string msg = sayi % 2 == 0 ? "girilen sayı çift sayısır" : "Girilen sayı tek sayıdır.";

Console.WriteLine(msg);
