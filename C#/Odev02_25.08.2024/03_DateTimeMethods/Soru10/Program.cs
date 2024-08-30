namespace Soru10;

class Program
{
    static void Main(string[] args)
    {
        // 10. Kullanıcıdan alınan bir saati, 12 saat formatından 24 saat formatına (veya tam tersi) çeviren bir program yazın.
        Console.WriteLine("Lutfen bana bir saat verin. (Ornek : 16:00:00)");
        string saat = Convert.ToString(Console.ReadLine());
        TimeSpan saat2 = TimeSpan.Parse(saat);
        var saat3 = new DateTime().Add(saat2).ToString("hh:mm tt");
        Console.WriteLine(saat3);
    }
}
