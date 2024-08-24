

namespace CSharp02_AnaMethod;

class Program
{
    static void Main(string[] args)
    {
         Console.WriteLine("---Girdiginiz tarihten bu yana ne kadar zaman gecti?---");
         mkaa();
         Console.ReadLine();
    }

     private static void mkaa()
     {
         Console.WriteLine("Lutfen bir tarih giriniz! (Orn : 25.12.2006)");
         var yil = Console.ReadLine();
         DateTime gunumuz = DateTime.Now;
         DateTime yeni = Convert.ToDateTime(yil);
         var abc = (gunumuz - yeni);
         Console.WriteLine ("Girdiginiz yildan bu yana; ");
         Console.WriteLine (abc.Days / 365 + " yil gecti.");
         Console.WriteLine (abc.Days + " gun gecti.");
         Console.WriteLine (abc.TotalHours + " saat gecti.");
         Console.WriteLine (abc.TotalMinutes + " dakika gecti.");
         Console.WriteLine (abc.TotalSeconds + " saniye gecti.");
    }
}
