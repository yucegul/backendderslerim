namespace Soru1;

class Program
{
    static void Main(string[] args)
    {
    //    1. 10 elemanlı rastgele değerlerden oluşan bir tam sayı dizisi içinde, dizinin her bir elemanının yalnızca bir önceki ve bir sonraki elemanı ile kıyaslandığı bir algoritma yazın.
    //     Bu algoritma, yalnızca kendinden önceki sayı ve kendinden sonraki sayı büyük olan elemanları bulmalı ve bunları ekrana yazdırmalıdır.
      
      int[] sayi = new int[10];
      Random krs = new Random();
      int sayi1 = 1;
      int sayi2 = 100;
      for(int i = sayi1;i<=sayi2;i++){
          for(int x=0;x<10;x++){
             sayi[x] = krs.Next(sayi1, sayi2);
          }
          } 
    for (int i = 1; i < sayi.Length - 1; i++)
        {
            if (sayi[i] > sayi[i - 1] && sayi[i] > sayi[i + 1])
            {
                Console.WriteLine(sayi[i]);
            }
        }
    }
}
