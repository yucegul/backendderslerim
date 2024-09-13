namespace Soru10;

class Program
{
    static void Main(string[] args)
    {
        // 10. 10 elemanlı bir dizi oluşturun ve bu dizinin elemanlarını bir başka diziye ters sırada kopyalayın.
        //  İlk dizideki sıralama değişmeyecek, sadece ikinci dizideki sıralama ters olacak.

        Random krsk = new Random();
        int[] dizi = new int[10];
        int[] ters;
        int ters1 = 0;
            
            Console.WriteLine("Dizinin normal hali");
        for(int i = 0; i<dizi.Length;i++){
            dizi[i] = krsk.Next(1,50);
            Console.Write(dizi[i] + " ");
        }
        Console.WriteLine();
        Console.WriteLine("---------------------------------");
        
        Array.Reverse(dizi);

            Console.WriteLine("Dizinin ters hali");
        for(int i = 0; i<dizi.Length;i++){
            Console.Write(dizi[i] + " ");
        }
        
    }
}
