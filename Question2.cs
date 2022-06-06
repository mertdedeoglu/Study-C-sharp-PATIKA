using System;
using System.Collections.Generic;
/*Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). 
Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. 
Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.*/
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            do
            {
                Console.WriteLine("Lütfen 2 Pozitif Sayı Giriniz: ");
                a = Convert.ToInt32(Console.ReadLine());
                b = Convert.ToInt32(Console.ReadLine());
            } while (a <= 0 || b <= 0);
            Console.WriteLine("Lütfen {0} Pozitif Sayı Daha Girin", a);
            List<int> sayılar = new List<int>();
            for (int i = 0; i < a; i++)
            {

                int sayi = int.Parse(Console.ReadLine());
                if (sayi % b == 0) 
                    sayılar.Add(sayi);
            }
            foreach (var item in sayılar)
            {
                Console.Write(item + " ");
            }
        }
    }
}
