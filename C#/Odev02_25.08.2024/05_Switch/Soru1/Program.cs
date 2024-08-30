namespace Soru1;

class Program
{
    static void Main(string[] args)
    {
        // 1. Kullanıcıdan alınan bir sayıya göre (1-7 arası) haftanın gününü yazdıran bir program yazın.
        Console.WriteLine("Lutfen bana bir sayi veriniz.");
        int sayi = Convert.ToInt32(Console.ReadLine());
        switch(sayi){
            case 1:
            Console.WriteLine("Sayinin gunu = Pazartesi");
            break;
            case 2:
            Console.WriteLine("Sayinin gunu = Sali");
            break;
            case 3:
            Console.WriteLine("Sayinin gunu = Carsamba");
            break;
            case 4:
            Console.WriteLine("Sayinin gunu = Persembe");
            break;
            case 5:
            Console.WriteLine("Sayinin gunu = Cuma");
            break;
            case 6:
            Console.WriteLine("Sayinin gunu = Cumartesi");
            break;
            case 7:
            Console.WriteLine("Sayinin gunu = Pazar");
            break;
        }
    }
}
