namespace Soru5;

class Program
{
    static void Main(string[] args)
    {
        // 5. Kullanıcıdan alınan bir metinde, yine kullanıcıdan alınan başka bir metni arayan ve varsa ilk bulunduğu indeksi yazdıran bir program yazın.
        Console.WriteLine("Lutfen 2 adet metin giriniz.");
        string metin1 = Console.ReadLine();
        string metin2 = Console.ReadLine();
        bool varMi = metin1.Contains(metin2);
        if(varMi) {
            int indeks = metin1.IndexOf(metin2);
            Console.WriteLine("Ikinci sozcugun basladigi indeks = "+indeks);
        }
    }
}
