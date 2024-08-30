namespace Soru3;

class Program
{
    static void Main(string[] args)
    {
        // 3. Kullanıcıdan alınan bir tarihe belirli bir gün sayısı ekleyerek yeni tarihi bulan bir program yazın.
        Console.WriteLine("Lutfen bir tarih giriniz. (Orn : 25.12.2006)");
        DateTime tarih = Convert.ToDateTime(Console.ReadLine());
        Console.WriteLine($"Girdiginiz tarihten 10 gun sonrasi = {tarih.AddDays(10)}");
   }
}
