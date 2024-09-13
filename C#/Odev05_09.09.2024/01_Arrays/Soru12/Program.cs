namespace Soru12;

class Program
{
    static void Main(string[] args)
    {
        // 100 elemanlı rastgele değerlerden oluşan bir tam sayı dizisinde en sık tekrar eden elemanı bulan ve kaç defa tekrarlandığını ekrana yazdıran bir program yazın.
        //  Bu işlemi bir foreach döngüsü ile gerçekleştirin.

        Random krsk = new Random();
        int[] dizi = new int[100];
        int[] sayac = new int[100];
        int tekrar = 0;

        for(int i = 0 ; i < dizi.Length;  i++){
            dizi[i] = krsk.Next(0,100);
        }
        
        foreach(int sayi in dizi){
            sayac[sayi]++;
        }
        
        int maksimum = sayac[0]; 

        for(int i = 0; i < sayac.Length; i++){
            if(sayac[i] > maksimum){
                maksimum = sayac[i];
                tekrar = i;
            }
        }
        
        Console.WriteLine($"En cok tekrar eden sayı: {tekrar}, kac tekrar: {maksimum}");
    }
}
