namespace Soru8;

class Program
{
    static void Main(string[] args)
    {
        // Kullanıcıdan alınan bir sayının 3'e ve 5'e tam bölünüp bölünmediğini kontrol eden ve uygun mesajı veren bir program yazın.
        Console.WriteLine("Lutfen bana bir sayi verin.");
        int sayi = Convert.ToInt32(Console.ReadLine());
        if (sayi % 3 == 0 && sayi % 5 == 0){
            Console.WriteLine("Sayiniz 3'e ve 5'e bolunebilmektedir.");
        }
        else if (sayi % 3 == 0){
            Console.WriteLine("Sayiniz 3'e bolunebilmektedir.");
        }
        else if (sayi % 5 == 0){
            Console.WriteLine("Sayiniz 5'e bolunebilmektedir.");
        }
        else{
            Console.WriteLine("Sayiniz 3'e de 5'e de bolunemez.");
        }
    }
}
