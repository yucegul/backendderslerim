
namespace Soru02;

class Program
{
    static void Main(string[] args)
    {
        // 2. İki sayıyı karşılaştıran ve en büyüğünü döndüren bir metot yazın.
        Console.WriteLine("Lutfen 2 tane sayi giriniz.");
        int sayi = int.Parse(Console.ReadLine());
        int sayi2 = int.Parse(Console.ReadLine());
        int enbuyuk = sayiBuyuk(sayi, sayi2);
        Console.WriteLine(enbuyuk);
    }

    static int sayiBuyuk(int a, int b)
    {
        if(a>b){
           return a;
        }
        else{
            return b;
        }
    }
}
