namespace Soru5;

class Program
{
    static void Main(string[] args)
    {
        // 5. Kullanıcıdan alınan iki sayı için üs alma işlemi yapan bir program yazın (örneğin, 2^3).
        Console.WriteLine("Lutfen iki sayi giriniz.");
        double sayi1 = Convert.ToDouble(Console.ReadLine());
        double sayi2 = Convert.ToDouble(Console.ReadLine());
        double pow = Convert.ToDouble(Math.Pow(sayi1, sayi2));
        Console.WriteLine($"{sayi1} ^ {sayi2} = {pow}");
    }
}
