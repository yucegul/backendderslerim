namespace Soru7;

class Program
{
    static void Main(string[] args)
    {
        // 50 elemanlı rastgele değerlerden oluşan bir tam sayı dizisindeki tüm çift sayıları toplayan ve bu toplamı ekrana yazdıran bir program yazın.
        //  foreach döngüsü kullanarak bu işlemi gerçekleştirin.

        Random krsk = new Random();
        int[] dizi = new int[50];

        for(int i = 0; i<dizi.Length; i++){
            dizi[i] = krsk.Next(0,100);
        }
        
        int toplam = 0;

        foreach(int cift in dizi){
           if(cift % 2 == 0){
            toplam += cift;
           }
        }
        
        Console.WriteLine(toplam);
    }
}
