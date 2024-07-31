using System;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;

class Program
{
    static void Main()
    {
        // Metodlarımızı  çağırıyoruz
        FavLyrics();
        Console.WriteLine("-------------------------------------------");
        int remainder = RemainderRandomNum();
        Console.WriteLine("Rastgele sayının 2 ye bölümünden kalan: " + remainder);
        Console.WriteLine("-------------------------------------------");
        int a = 15;
        int b = 20;
        int prdct = MultplyNum(a, b);
        Console.WriteLine("Çarpım: " + prdct);
        Console.WriteLine("-------------------------------------------");
        string firstName = "Emre";
        string lastName = "Şekerci";
        Welcome(firstName, lastName);

    }

    // Geriye değer döndürmeyen void metot
    static void FavLyrics()
    {
        // Ekrana şarkı sözlerini yazdırma
        Console.WriteLine("Sustu bu gece,karardı yine ay");

    }


    static int RemainderRandomNum()
    {
        Random random = new Random();
        int randomNum = random.Next();
        int remainder = randomNum % 2;
        return remainder;
    }
    static int MultplyNum(int a, int b)
    {
        return a * b;
    }
    static void Welcome(string firstName, string lastName)
    {
        Console.WriteLine("Hoş Geldiniz: " + firstName + " " + lastName);
    }

}