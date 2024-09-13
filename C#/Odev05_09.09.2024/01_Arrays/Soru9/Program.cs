namespace Soru9;

class Program
{
    static void Main(string[] args)
    {
        // 9. Verilen bir dizinin yalnızca pozitif sayılarını ters çeviren bir algoritma yazın. Diziyi tararken,
        //  sadece pozitif sayıların yerini değiştirmelisiniz, diğer elemanlar aynı kalmalı.
        
        int[] dizi = [10,-5,-9,2,5,-17,22,-3];
        int[] pozitif;
        int pozitif1 = 0;

        pozitif = new int[dizi.Length];
        for(int i = 0; i<dizi.Length;i++){
             if(dizi[i] >= 0){
                pozitif[pozitif1] = dizi[i];
                pozitif1++;
             }
        }

        Array.Reverse(pozitif);
        foreach(int sonuc in pozitif){
            Console.WriteLine(sonuc);
        }

        // ??

    }
}
