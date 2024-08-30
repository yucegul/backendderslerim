namespace Soru5;

class Program
{
    static void Main(string[] args)
    {
        // 5. Kullanıcıdan alınan bir sayıya göre (1-4 arası) mevsim adını yazdıran bir program yazın.
        Console.WriteLine("Lutfen bana bir sayi veriniz.");
        int sayi = Convert.ToInt32(Console.ReadLine());
        switch(sayi){
            case 1:
            Console.WriteLine("Mevsiminiz : Ilkbahar");
            break;
            case 2:
            Console.WriteLine("Mevsiminiz = Yaz ");
            break;
            case 3:
            Console.WriteLine("Mevsiminiz = Sonbahar");
            break;
            case 4:
            Console.WriteLine("Mevsiminiz = Kis");
            break;
        }
    }
}
