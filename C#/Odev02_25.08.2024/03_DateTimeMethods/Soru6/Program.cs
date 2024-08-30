using Microsoft.VisualBasic;

namespace Soru6;

class Program
{
    static void Main(string[] args)
    {
        // 6. Kullanıcıdan alınan bir yılın artık yıl olup olmadığını kontrol eden bir program yazın.
        Console.WriteLine("Lutfen bana bir yil veriniz.");
        int yeni = Convert.ToInt32(Console.ReadLine());
        if (DateTime.IsLeapYear(yeni))
        {
            Console.WriteLine("Girdiginiz yil artik bir yildir.");
        }
        else{
            Console.WriteLine("Girdiginiz yil artik bir yil degildir.");
        }
    }
}
