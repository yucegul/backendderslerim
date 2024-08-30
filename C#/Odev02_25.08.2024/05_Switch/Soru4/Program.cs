namespace Soru4;

class Program
{
    static void Main(string[] args)
    {
        // 4. Kullanıcıdan alınan bir harfe göre sesli veya sessiz harf olduğunu belirleyen bir program yazın.
        Console.WriteLine("Lutfen bana bir harf giriniz.");
        char harf = Convert.ToChar(Console.ReadLine());
        switch(harf){
            case 'a':
            case 'e':
            case 'u':
            case 'ü':
            case 'o':
            case 'ö':
            case 'ı':
            case 'i':
            Console.WriteLine("Harfiniz sesli bir harftir.");
            break;
            default:
            Console.WriteLine("Harfiniz sessiz bir harftir.");
            break;
        }
    }
}
