namespace Soru3;

class Program
{
    static void Main(string[] args)
    {
        // 3. Kullanıcıdan alınan bir sayının mutlak değerini hesaplayan bir program yazın.
        Console.WriteLine("Lutfen bir sayi giriniz.");
        double sayi = Convert.ToDouble(Console.ReadLine());
        double mutlak = Convert.ToDouble(Math.Abs(sayi));
        Console.WriteLine($"Girdiginiz sayinin mutlak degeri = {mutlak}");
    }
}
