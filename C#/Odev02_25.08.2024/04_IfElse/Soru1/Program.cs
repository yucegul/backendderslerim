namespace Soru1;

class Program
{
    static void Main(string[] args)
    {
        // 1. Kullanıcıdan alınan bir sayının pozitif, negatif veya sıfır olduğunu kontrol eden bir program yazın.
        Console.WriteLine("Lutfen bana bir sayi veriniz.");
        int sayi = Convert.ToInt32(Console.ReadLine());
        if(sayi > 0){
            Console.WriteLine("Sayiniz pozitif.");
        }
        else if(sayi < 0){
            Console.WriteLine("Sayiniz negatif.");
        }
        else{
            Console.WriteLine("Sayiniz notr.");
        }
    }
}
