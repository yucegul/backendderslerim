using System.Security.Cryptography.X509Certificates;

namespace Soru15;

class Program
{
    static void Main(string[] args)
    {
        // 15. Bir dizideki elemanları küçükten büyüğe sıralayan bir algoritma yazın.
        //  Ancak sıralama sırasında sadece tek sayılar sıralanmalı, çift sayılar yerlerinde kalmalıdır.
        Random rnd = new Random();
        int[] dizi = new int[20];

        for(int i = 0; i<dizi.Length;i++){
           dizi[i] = rnd.Next(1,50);
        }
 
        var tek = dizi.Where(x => x % 2 != 0).OrderBy(x => x).ToArray();
        
        int tek2 = 0;



        for(int i = 0; i<dizi.Length;i++){
            if(dizi[i] % 2 != 0){
               dizi[i] = tek[tek2];
               tek2++;
            }
            Console.WriteLine(dizi[i]);
        }
        
        
    }
}
