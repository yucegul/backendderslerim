namespace Soru17;

class Program
{
    static void Main(string[] args)
    {
        // 17. Bir dizideki en büyük iki sayıyı bulan bir program yazın.
        // Bu programı bir for döngüsü ile yazın, ancak aynı sayının iki defa en büyük olarak seçilmesine izin vermeyin.

        Random rnd = new Random();
        int[] dizi = new int[100];
        int buyuk = int.MinValue;
        int buyuk2 = int.MinValue;

        for(int i = 0; i<dizi.Length;i++){
           dizi[i] = rnd.Next(1,100);
        }

        for(int i = 0; i<dizi.Length;i++){
           if(dizi[i] > buyuk){
            buyuk2 = buyuk;
            buyuk = dizi[i];
           }
           if(dizi[i]> buyuk2 && dizi[i] != buyuk){
                buyuk2 = dizi[i];
           }
        }

        Console.WriteLine("---------------");
        Console.WriteLine(buyuk);
        Console.WriteLine(buyuk2);
    }
}
