namespace Soru8;

class Program
{
    static void Main(string[] args)
    {
        // Klavyeden girilen bir sayıyı, 10 elemanlı rastgele değerlerden oluşan bir tam sayı dizisinde aratın.
        //  Eğer sayı dizide yoksa, diziyi sıralayın ve sayıyı dizinin doğru(olması gereken sıra) yerine ekleyin. Ekledikten sonra yeni diziyi ekrana yazdırın.
        
        Console.WriteLine("Lutfen bir sayi giriniz!");
        int cevap = Convert.ToInt32(Console.ReadLine());
        Random krsk = new Random();
        int[] dizi = new int[10];


        for(int i = 0; i<dizi.Length;i++){
           dizi[i] = krsk.Next(0,10);
        }
        
        bool varMi = false;
        
        for(int i = 0; i<dizi.Length;i++){
            if(dizi[i] == cevap){
                Console.WriteLine($"{cevap} tekrari = {i}. indexte!");
                varMi = true;
            }
        }
        

        
           
        
        
    }
}
