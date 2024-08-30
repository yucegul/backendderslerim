namespace Soru4;

class Program
{
    static void Main(string[] args)
    {
        // 4. Kullanıcıdan alınan bir sayının karekökünü hesaplayan bir program yazın.
        Console.WriteLine("Lutfen bir sayi giriniz.");
        double sayi = Convert.ToDouble(Console.ReadLine());
        double sayi2 = Convert.ToDouble(Math.Sqrt(sayi));
        Console.WriteLine($"Sayinizin karekoku = {sayi2}");
    }
}
