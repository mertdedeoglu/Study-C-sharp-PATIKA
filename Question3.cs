using System;
using System.Collections.Generic;

/*Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). 
Sonrasında kullanıcıdan n adet kelime girmesi isteyin. 
Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.*/

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            do
            {
                Console.WriteLine("Lütfen 1 adet pozitif sayı giriniz: ");
                a = int.Parse(Console.ReadLine());
            } while (a <= 0);
            Console.WriteLine("Lütfen {0} tane kelime girin: ", a);
            List<string> kelimeler = new List<string>();
            for (int i = 0  ; i < a; i++)
            {
                kelimeler.Add(Console.ReadLine());
            }
            for (int i = kelimeler.Count; i > 0 ; i--)
            {
                Console.Write(kelimeler[i-1] + " ");
            }
        }
    }
}
