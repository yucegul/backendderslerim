namespace Soru14;

class Program
{
    static void Main(string[] args)
    {
        // 14. 20 elemanlı bir dizi oluşturun.
        // Bu dizideki elemanların 3’e bölünebilenlerin ??toplamını?? bulan bir algoritma yazın.
        // Sonucu ekrana yazdırırken her 5. elemandan sonra bir boşluk bırakın.

        Random krsk = new Random();
        int[] dizi = new int[20];
        int[] bolunebilen;
        int bolunebilen2 = 0;


        for(int i = 0 ; i<dizi.Length;i++){
            dizi[i] = krsk.Next(1,100);
        }

        bolunebilen = new int[dizi.Length];
        
        for(int i = 0; i<dizi.Length;i++){
           if(dizi[i] % 3 == 0){
              bolunebilen[bolunebilen2] = dizi[i];
              bolunebilen2++;
           }
        }
        
        for (int i = 0; i < bolunebilen2; i++)
        {
            Console.Write(bolunebilen[i]);

            if (i != bolunebilen2 - 1)
            {
                Console.Write(" ");
            }

            if ((i + 1) % 5 == 0 && i != bolunebilen2 - 1)
            {
                Console.WriteLine(" ");
            }
            
        }
        
        Console.WriteLine();
    }
}
