using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Soru06;

class Program
{
    static void Main(string[] args)
    {
        // 6. Parametre olarak bir sayı alıp, tek mi çift mi olduğunu döndüren bir metot yazın.
        Console.WriteLine("Lutfen bir sayi giriniz.");
        int sayi = Convert.ToInt32(Console.ReadLine());
        string sanakalmis = Morolur(sayi);
        Console.WriteLine(sanakalmis);
    }
    static string Morolur(int sayi)
    {
        if(sayi % 2 == 0){
            return "Cift";
        }
        else{
            int tek = 1;
            return "Tek";
        }
    }
}
