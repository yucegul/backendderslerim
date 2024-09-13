namespace Soru3;

class Program
{
    static void Main(string[] args)
    {
        // 3. 10 elemanlı rastgele değerlerden oluşan bir dizideki tüm pozitif sayıları ve negatif sayıları ayrı dizilere ayıran ve her iki diziyi de ekrana yazdıran bir program yazın.
        //  İşlemi gerçekleştirmek için while döngüsü kullanın.

         Random krsk = new Random();
         int[] dizi = new int[10];
         
         int[] pozitif = new int[10];
         int[] negatif = new int[10];

         int pozitif1= 0;
         int negatif1= 0;

         int i = 0;

         while(i<10)
         {
            dizi[i] = krsk.Next(-100,100);
            i++;
         }

         i = 0;

         while(i < 10){
           if(dizi[i] > 0){
              pozitif[pozitif1] = dizi[i];
              pozitif1++;
           }
           else if(dizi[i] <0){
            negatif[negatif1] = dizi[i];
            negatif1++;
           }
           i++;
         }

         for(i = 0; i<pozitif1;i++){
            Console.WriteLine(pozitif[i]);
           }
           Console.WriteLine();
           for(i = 0; i<negatif1;i++){
            Console.WriteLine(negatif[i]);
           }
    }
}
