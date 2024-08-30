namespace Soru7;

class Program
{
    static void Main(string[] args)
    {
        // 7. Kullanıcıdan alınan bir açının (derece cinsinden) radyan cinsinden değerini hesaplayan bir program yazın.
        Console.WriteLine("Lutfen bir aci giriniz. (derece olarak)");
        double sayi = Convert.ToDouble(Console.ReadLine());
        double radian = Convert.ToDouble((Math.PI / 180) * sayi);
        Console.WriteLine($"Girdiginiz acinin radyan cinsinden degeri + {radian}");
    }
}
