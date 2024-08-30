namespace Soru9;

class Program
{
    static void Main(string[] args)
    {
        // 9. Kullanıcıdan alınan iki sayı arasındaki küçük olanı bulan bir program yazın.
        Console.WriteLine("Lutfen iki sayi giriniz.");
        double sayi1 = Convert.ToDouble(Console.ReadLine());
        double sayi2 = Convert.ToDouble(Console.ReadLine());

        if(sayi1 < sayi2){
            Console.WriteLine($"Girdiginiz ilk sayi ({sayi1}) girdiginiz ikinci sayidan ({sayi2}) kucuktur.");
        }
        else{
            Console.WriteLine($"Girdiginiz ikinci sayi ({sayi2}) girdiginiz ilk sayidan ({sayi1}) kucuktur.");
        }
    }
}
