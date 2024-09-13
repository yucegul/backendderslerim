namespace Soru6;

class Program
{
    static void Main(string[] args)
    {
        // 6. 100 elemanlı rastgele değerlerden oluşan bir tam sayı dizisinde en büyük ve en küçük sayıyı bulan programı yazın.

        Random krsk = new Random();
        int[] dizi = new int[100];

        for(int i = 0; i<dizi.Length;i++){
           dizi[i] = krsk.Next(0,100);
        }

        int max = dizi[0];
        int min = dizi[0];

        for(int i = 0; i<dizi.Length;i++){
            if(dizi[i] > max){
                max = dizi[i];
            }
            else if(dizi[i] < min){
                min = dizi[i];
            }
        }

        Console.WriteLine($@"
En buyuk = {max} 
En kucuk = {min}");
    }
}
