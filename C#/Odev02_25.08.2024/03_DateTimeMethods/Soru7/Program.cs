namespace Soru7;

class Program
{
    static void Main(string[] args)
    {
        // 7. Belirli bir tarih formatında (örneğin, "dd/MM/yyyy") girilen bir tarihi DateTime nesnesine çeviren ve ekrana yazdıran bir program yazın.
        Console.WriteLine("Lutfen bana bir tarih verin. (Ornek : 25/12/2006)");
        string tarih = Console.ReadLine();
        DateTime tarih2 = Convert.ToDateTime(tarih);
        Console.WriteLine($"Metninizin DateTime'a donusturulmus hali = {tarih2}");
    }
}
