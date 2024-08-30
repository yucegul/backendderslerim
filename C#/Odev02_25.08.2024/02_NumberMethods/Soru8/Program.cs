namespace Soru8;

class Program
{
    static void Main(string[] args)
    {
        // 8. Kullanıcıdan alınan bir sayının logaritmasını (doğal logaritma) hesaplayan bir program yazın.
        Console.WriteLine("Lutfen bir sayi giriniz.");
        double sayi = Convert.ToDouble(Console.ReadLine());
        double log = Convert.ToDouble(Math.Log(sayi));
        Console.WriteLine($"Girdiginiz sayinin logaritmasi = {log}");
    }
}
