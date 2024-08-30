namespace Soru2;

class Program
{
    static void Main(string[] args)
    {
        // 2. Kullanıcıdan alınan iki sayıdan hangisinin daha büyük olduğunu bulan bir program yazın.
        Console.WriteLine("Lutfen 2 sayi giriniz.");
        double sayi1 = Convert.ToDouble(Console.ReadLine());
        double sayi2 = Convert.ToDouble(Console.ReadLine());

        if (sayi1 > sayi2){
            Console.WriteLine ($"Ilk girdiginiz sayi ({sayi1}) ikinci girdiginiz sayidan ({sayi2}) buyuktur.");
        }
        else{
            Console.WriteLine ($"Ikinci girdiginiz sayi ({sayi2}) ilk girdiginiz sayidan ({sayi1}) buyuktur.");
        }
    }
}
