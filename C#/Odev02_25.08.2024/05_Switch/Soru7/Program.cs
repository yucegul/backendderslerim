namespace Soru7;

class Program
{
    static void Main(string[] args)
    {
        // 7. Kullanıcıdan alınan bir sayıya göre (1-5 arası) Türk para biriminin adını yazdıran bir program yazın (1 Kr, 5 Kr, 10 Kr, 25 Kr, 50 Kr).
        Console.WriteLine("Lutfen bana bir sayi veriniz.");
        int sayi = Convert.ToInt32(Console.ReadLine());
        switch(sayi){
            case 1:
            Console.WriteLine("1 Kurus");
            break;
            case 2:
            Console.WriteLine("5 Kurus");
            break;
            case 3:
            Console.WriteLine("10 Kurus");
            break;
            case 4:
            Console.WriteLine("25 Kurus");
            break;
            case 5:
            Console.WriteLine("50 Kurus");
            break;
         }
    }

}
