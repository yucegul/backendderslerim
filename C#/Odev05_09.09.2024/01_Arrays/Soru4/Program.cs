namespace Soru4;

class Program
{
    static void Main(string[] args)
    {
        //4. 100 elemanlı rastgele değerlerden oluşan bir tam sayı dizisinde tekrar eden elemanları bulan bir program yazın.
        //  Diziyi tararken, elemanların hangi pozisyonlarda(kaçıncı indexte) tekrarlandığını ekrana yazdırın. Bu işlemi hem for hem de foreach döngüleri ile gerçekleştirin.

        Random krsk = new Random();
        int[] dizi = new int[100];
        for(int i = 0; i<100 ; i++){
            dizi[i] = krsk.Next(0,100);
        }
        
        for(int i = 0; i<dizi.Length; i++){
            for(int x = i+1; x<100; x++)
            {
            if(dizi[i] == dizi[x])
            {
               Console.WriteLine($"{dizi[i]} tekrari = {i} ve {x}");
            }
           }
        }
    }
}
