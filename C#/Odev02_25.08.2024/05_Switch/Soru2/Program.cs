namespace Soru2;

class Program
{
    static void Main(string[] args)
    {
        // 2. Kullanıcıdan alınan bir sayıya göre (1-12 arası) ayın adını yazdıran bir program yazın.
        Console.WriteLine("Lutfen bana bir sayi veriniz.");
        int sayi = Convert.ToInt32(Console.ReadLine());
        switch(sayi){
            case 1:
            Console.WriteLine("Sayinin ayi = Ocak");
            break;
            case 2:
            Console.WriteLine("Sayinin ayi = Subat");
            break;
            case 3:
            Console.WriteLine("Sayinin ayi = Mart");
            break;
            case 4:
            Console.WriteLine("Sayinin ayi = Nisan");
            break;
            case 5:
            Console.WriteLine("Sayinin ayi = Mayis");
            break;
            case 6:
            Console.WriteLine("Sayinin ayi = Haziran");
            break;
            case 7:
            Console.WriteLine("Sayinin ayi = Temmuz");
            break;
            case 8:
            Console.WriteLine("Sayinin ayi = Agustos");
            break;
            case 9:
            Console.WriteLine("Sayinin ayi = Eylul");
            break;
            case 10:
            Console.WriteLine("Sayinin ayi = Ekim");
            break;
            case 11:
            Console.WriteLine("Sayinin ayi = Kasim");
            break;
            case 12:
            Console.WriteLine("Sayinin ayi = Aralik");
            break;
        }
    }
}
