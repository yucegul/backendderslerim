namespace Soru5;

class Program
{
    static void Main(string[] args)
    {
        //5. Klavyeden girilen bir sayının, 100 elemanlı rastgele değerlerden oluşan bir tam sayı dizisinde olup olmadığını kontrol eden bir algoritma yazın.
        //  Eğer sayı dizide varsa, sayının dizideki yerini ve tekrar sayısını ekrana yazdırın.

        Random krsk = new Random();
        int[] dizi = new int[100];

        for(int i = 0; i<dizi.Length;i++){
           dizi[i] = krsk.Next(0,100);
        }
        Console.WriteLine("Lutfen bir sayi giriniz.");
        int sayi = Convert.ToInt32(Console.ReadLine());

        bool varMi = false;

        for(int i = 0; i<dizi.Length;i++){
                if(sayi == dizi[i]){
                   Console.WriteLine($"{sayi} tekrari = {i}. indexte!");
                   varMi = true;
                }
        }
         if (!varMi)
        {
            Console.WriteLine($"{sayi} dizide yok.");
        }
    }
}
