namespace Soru6;

class Program
{
    static void Main(string[] args)
    {
        // 6. Kullanıcıdan alınan bir sayının trigonometrik sinüs değerini hesaplayan bir program yazın.
        Console.WriteLine("Lutfen bir sayi giriniz.");
        double sayi = Convert.ToDouble(Console.ReadLine());
        double sin = Convert.ToDouble(Math.Sin(sayi));
        Console.WriteLine($"Girdiginiz sayinin sinus degeri (radyan) = {sin}");
    }
}
