namespace Soru1;

class Program
{
    static void Main(string[] args)
    {
        // 1. Kullanıcıdan alınan bir cümledeki kelime sayısını bulan bir program yazın.
        Console.WriteLine("Lutfen bir cumle giriniz!");
        string cumle = Convert.ToString(Console.ReadLine());
        string[] kelime = cumle.Split(" ");
        int kelimesayisi = kelime.Length;
        Console.WriteLine("Cumlenizde " + kelimesayisi + " kelime var.");
    }
}
