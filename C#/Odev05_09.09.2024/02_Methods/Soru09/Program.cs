
namespace Soru09;

class Program
{
    static void Main(string[] args)
    {
        // 9. Bir sayı dizisi alıp, bu listedeki en küçük sayıyı döndüren bir metot yazın.
        int[] dizi = [12, 22, 13, 11, 4, 6, 55, 44];
        int cevir = Dondur(dizi);
        Console.WriteLine(cevir);
    }

    static int Dondur(int[] dizi)
    {
        int min=dizi[0];
        for(int i = 0; i<dizi.Length;i++){
            if(dizi[i] < min){
                min = dizi[i];
            }
        }
        return min;
    }
}
