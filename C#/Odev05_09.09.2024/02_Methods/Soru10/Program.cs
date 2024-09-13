
namespace Soru10;

class Program
{
    static void Main(string[] args)
    {
    //    10. Bir sayı dizisi alıp, dizideki tüm elemanların toplamını döndüren bir metot yazın.
          int[] dizi = [12,22,5,61,22,11];
          int sonuc = YeniMetod(dizi);
          Console.WriteLine(sonuc);
    }

    static int YeniMetod(int[] dizi)
    {
        int toplam = 0;
        foreach(int toplam1 in dizi){
               toplam += toplam1; 
        }
        return toplam;
    }
}
