namespace Soru1;

class Program
{
    static void Main(string[] args)
    {
        // 1. Kullanıcıdan alınan bir tarihin haftanın hangi günü olduğunu bulan bir program yazın.
        Console.WriteLine("Lutfen bir tarih giriniz. (Orn : 25.12.2006)");
        DateTime tarih = Convert.ToDateTime(Console.ReadLine());
        Console.WriteLine($"Girdigin tarihte gun = {tarih.DayOfWeek}");
    }
}
