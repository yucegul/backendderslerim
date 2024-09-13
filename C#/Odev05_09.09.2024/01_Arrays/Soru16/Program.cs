namespace Soru16;

class Program
{
    static void Main(string[] args)
    {
        // 16. do-while döngüsü kullanarak, klavyeden girilen sayıları bir diziye ekleyin.
        //  Kullanıcı sıfır girdiğinde döngüden çıkın ve dizideki tüm sayılarla birlikte ortalamayı ekrana yazdırın.
        
        int toplam = 0;
        int sayi;
        List<int> liste = new List<int>();
        Console.WriteLine("Ortalamasini istediginiz sayilari girip cikmak icin 0'a basiniz.");

        do{
           sayi = Convert.ToInt32(Console.ReadLine());

           if(sayi != 0){
                liste.Add(sayi);
                toplam+=sayi;
           }
        }while(sayi != 0);

        if(liste.Count > 0){
            double ortalama = (double)toplam/liste.Count;
            
            Console.WriteLine("-------------------------");
            Console.WriteLine(ortalama);
        }
    }
}
