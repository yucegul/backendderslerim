namespace Soru4;

class Program
{
    static void Main(string[] args)
    {
        // 4. İki tarih arasındaki gün farkını hesaplayan bir program yazın.
        Console.WriteLine("Gun farklarini bulabilmem icin lutfen 2 tarih giriniz.");
        DateTime tarih1 = Convert.ToDateTime(Console.ReadLine());
        DateTime tarih2 = Convert.ToDateTime(Console.ReadLine());
        if(tarih1 > tarih2){
            Console.WriteLine($"Iki tarih arasindaki gun farki = {(tarih1-tarih2).Days}");
        }
        else{
            Console.WriteLine($"Iki tarih arasindaki gun farki = {(tarih2-tarih1).Days}");
        }
    }
}
