using System;
using System.Collections.Generic;
using System.Linq;

/*Soru - 1: Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın. (ArrayList sınıfını kullanara yazınız.)

Negatif ve numeric olmayan girişleri engelleyin.
Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.
Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın.*/

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int x = 1;
            List<int> asal = new List<int>();
            List<int> noasal = new List<int>();
            do
            {
                try
                {
                    a = int.Parse(Console.ReadLine());
                    a = a > 0 ? a : throw new Exception();
                    for (int i = 2; i < a; i++)
                    {
                        if (a % i == 0)
                        {
                            noasal.Add(a);
                            break;
                        }
                    }
                    if (!noasal.Contains(a))
                    {
                        asal.Add(a);
                    }
                    x++;
                }
                catch
                {
                    Console.WriteLine("Girdiğiniz değer pozitif sayı değildir.");
                }
            } while (x < 21);
            asal.Sort();
            asal.Reverse();
            noasal.Sort();
            noasal.Reverse();
            Console.WriteLine("Asal Olanlar");
            int toplamasal = 0;
            int toplamnoasal = 0;
            foreach (var item in asal)
            {
                toplamasal += item;
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Asal Olmayanlar");
            foreach (var item in noasal)
            {

                toplamnoasal += item;
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Asal ortalama: {0}, Asal olmayan ortalama: {1}",toplamasal/asal.Count,toplamnoasal/noasal.Count);
        }
    }
}
