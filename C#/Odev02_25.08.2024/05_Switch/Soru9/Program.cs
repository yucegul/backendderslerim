namespace Soru9;

class Program
{
    static void Main(string[] args)
    {
        // 9. Kullanıcıdan alınan bir sayıya göre (1-5 arası) Türkçe sayı sıfatını yazdıran bir program yazın (1: Birinci, 2: İkinci, vb.).
        Console.WriteLine("Lutfen bana bir sayi ver.");
        int sayi = Convert.ToInt32(Console.ReadLine());
        switch(sayi){
            case 1:
            Console.WriteLine("Birincisin!");
            break;
            case 2:
            Console.WriteLine("Ikincisin!");
            break;
            case 3:
            Console.WriteLine("Ucuncusun!");
            break;
            case 4:
            Console.WriteLine("Dorduncusun!");
            break;
            case 5:
            Console.WriteLine("Besincisin!");
            break;
        }
    }
}
