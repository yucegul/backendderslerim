namespace Soru10;

class Program
{
    static void Main(string[] args)
    {
        // 10. Kullanıcıdan alınan bir sayının asal olup olmadığını kontrol eden bir program yazın.
        Console.WriteLine("Lutfen bana bir sayi veriniz.");
        int sayi = Convert.ToInt32(Console.ReadLine());

        if (asalMi(sayi))
        {
        Console.WriteLine("Sayiniz asal bir sayidir.");
        }
        else
        {
        Console.WriteLine("Sayiniz asal degildir.");
        }       
    }
    public static bool asalMi(int sayi)
        {
        if (sayi <= 1) return false;
        if (sayi == 2) return true;
        if (sayi % 2 == 0) return false;

        var boundary = (int)Math.Floor(Math.Sqrt(sayi));
          int i = 3;
          do{
            i +=2  ;
          }
          while(i <= boundary);
          if (sayi % i == 0)
          return false;
          return true;

        // for (int i = 3; i <= boundary; i += 2)
        // if (sayi % i == 0)
        // return false;
    
        // return true;        
        }
}
