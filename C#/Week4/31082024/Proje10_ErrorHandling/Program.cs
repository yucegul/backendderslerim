namespace Proje10_ErrorHandling;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Lutfen bana alt sınır ve ust sınırı veriniz.");
        int min = Convert.ToInt32(Console.ReadLine());
        min = min % 2 == 0 ? min : min + 1;
        int max = Convert.ToInt32(Console.ReadLine());
        for (int counter = min; counter <= max; counter+=2){
            Console.WriteLine($"{counter}");

        }
       }
}
