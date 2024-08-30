namespace Soru10;

class Program
{
    static void Main(string[] args)
    {
        // 10. Kullanıcıdan alınan bir ondalıklı sayıyı, yine kullanıcıdan alınan ondalık basamak sayısına göre yuvarlayan bir program yazın.
        Console.WriteLine("Lutfen ondalikli bir sayi ve sayiyi yuvarlamak istediginiz ondalik basamak sayisini yaziniz.");
        decimal sayi1 = Convert.ToDecimal(Console.ReadLine());
        int sayi2 = Convert.ToInt32(Console.ReadLine());
        decimal sayi3 = Convert.ToDecimal(Math.Round(sayi1, sayi2));
        Console.WriteLine($"Sonucunuz = {sayi3}");
    }
}
