namespace Soru6;

class Program
{
    static void Main(string[] args)
    {
        // 6. Kullanıcıdan alınan bir nota göre (A, B, C, D, F) geçme veya kalma durumunu belirleyen bir program yazın.
        Console.WriteLine("Lutfen bana notunuzu giriniz. (A, B, C, D, F)");
        char not = Convert.ToChar(Console.ReadLine);
        switch(not){
            case 'A':
            case 'B':
            case 'C':
            case 'D':
            Console.WriteLine("Gectiniz.");
            break;
            case 'F':
            Console.WriteLine("Kaldiniz.");
            break;
            default:
            Console.WriteLine("Lutfen gecerli bir not giriniz!");
            break;
        }
    }
}
