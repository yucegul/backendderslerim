namespace Soru8;

class Program
{
    static void Main(string[] args)
    {
        // 8. Şu anki tarihin ay adını tam olarak yazdıran bir program yazın (örneğin, "Ağustos").
        DateTime tarih = DateTime.Now;
        switch(tarih.Month){
            case 1:
            Console.WriteLine("Ocak");
            break;
            case 2:
            Console.WriteLine("Subat");
            break;
            case 3:
            Console.WriteLine("Mart");
            break;
            case 4:
            Console.WriteLine("Nisan");
            break;
            case 5:
            Console.WriteLine("Mayis");
            break;
            case 6:
            Console.WriteLine("Haziran");
            break;
            case 7:
            Console.WriteLine("Temmuz");
            break;
            case 8:
            Console.WriteLine("Agustos");
            break;
            case 9:
            Console.WriteLine("Eylul");
            break;
            case 10:
            Console.WriteLine("Ekim");
            break;
            case 11:
            Console.WriteLine("Kasim");
            break;
            case 12:
            Console.WriteLine("Aralik");
            break;
        }
    }
}
