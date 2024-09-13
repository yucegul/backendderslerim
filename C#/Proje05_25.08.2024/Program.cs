using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Deneme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tarihinizi giriniz!");
            method1();
        }

        private static void method1()
        {
            DateTime now = DateTime.Now;
            DateTime ay = Convert.ToDateTime(Console.ReadLine());
            DateTime month = Convert.ToDateTime(ay.Month);
            Console.WriteLine(month);

            switch (ay.Month)
            {
                case 1:
                 Console.WriteLine("Kış mevsimindesiniz!");
                 break;

                case 2: 
                Console.WriteLine("Kış mevsimindesiniz!");
                break;

                case 3:
                 Console.WriteLine("İlkbahar amevsimindesiniz!");
                 break;

                 case 4:
                 Console.WriteLine("Kış mevsimindesiniz!");
                 break;

                 case 5:
                 Console.WriteLine("Kış mevsimindesiniz!");
                 break;
                 case 6:
                 Console.WriteLine("Kış mevsimindesiniz!");
                 break;
                 case 7:
                 Console.WriteLine("Kış mevsimindesiniz!");
                 break;
                 case 8:
                 Console.WriteLine("Kış mevsimindesiniz!");
                 break;
                 case 9:
                 Console.WriteLine("Kış mevsimindesiniz!");
                 break;
                 case 10:
                 Console.WriteLine("Kış mevsimindesiniz!");
                 break;
                 case 11:
                 Console.WriteLine("Kış mevsimindesiniz!");
                 break;
                 case 12:
                 Console.WriteLine("Kış mevsimindesiniz!");
                 break;
            }
        }
    }
}