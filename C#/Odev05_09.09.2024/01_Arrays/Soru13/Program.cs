namespace Soru13;

class Program
{
    static void Main(string[] args)
    {
        // 13. Bir dizideki tek sayıları toplayan ve bu toplamın çift mi, tek mi olduğunu kontrol eden bir program yazın.
        //  Toplamla birlikte eğer toplam tek ise, "Toplam tek sayı" mesajı, çift ise "Toplam çift sayı" mesajı ekrana yazdırılmalı.

        Random krsk = new Random();
        int[] dizi = new int[50];
        
        for(int i = 0; i<dizi.Length; i++)
        {
            dizi[i] = krsk.Next(1,50);
        }

        int toplam = 0;

        foreach(int toplam1 in dizi){
            if(toplam1 % 2 != 0){
               toplam += toplam1;
            }
        }
        
        if(toplam % 2 != 0){
          Console.WriteLine("Dizi toplami tek sayi");
        }
        else if (toplam % 2 == 0){
            Console.WriteLine("Dizi toplami cift sayi");
        }
    }
}
