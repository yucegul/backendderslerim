namespace Soru08;

class Program
{
    static void Main(string[] args)
    {
        // 8. Santigrat cinsinden verilen sıcaklığı Fahrenheit'e çeviren bir metot yazın.
        Console.WriteLine("Lutfen bana santigrat cinsinden sicaklik verin.");
        int sicaklik = Convert.ToInt32(Console.ReadLine());
        double fahrenheit = Cevirme(sicaklik);
        Console.WriteLine(fahrenheit);
    }

    static double Cevirme(int fahrenheit)
    {
        double ceviri = fahrenheit * 1.8 + 32;
        return ceviri;
    }
}
