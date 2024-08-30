namespace Soru5;

class Program
{
    static void Main(string[] args)
    {
        // 5. Kullanıcıdan alınan bir tarihin yılın kaçıncı günü olduğunu hesaplayan bir program yazın.
        Console.WriteLine("Lutfen bana bir tarih verin. (Ornek : 25.12.2006)");
        DateTime tarih = Convert.ToDateTime(Console.ReadLine());
        Console.WriteLine($"Girdiginiz tariih yilin kacinci gunu = {tarih.DayOfYear}");
    }
}
