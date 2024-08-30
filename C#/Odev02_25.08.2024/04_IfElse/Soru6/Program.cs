namespace Soru6;

class Program
{
    static void Main(string[] args)
    {
        // 6. Kullanıcıdan alınan bir notun aşağıdaki tabloya göre harf karşılığını veren bir program yazın.
        Console.WriteLine("Lutfen bana notunuzu giriniz.");
        int not = Convert.ToInt32(Console.ReadLine());

        if(not >= 90){
            Console.WriteLine("Notunuz :: AA");
        }
        else if(not >= 85){
           Console.WriteLine("Notunuz :: BA");
        }
        else if(not >= 80){
           Console.WriteLine("Notunuz :: BB");
        }
        else if(not >= 70){
           Console.WriteLine("Notunuz :: CB");
        }
        else if(not >= 60){
           Console.WriteLine("Notunuz :: CC");
        }
        else if(not >= 55){
           Console.WriteLine("Notunuz :: DC");
        }
        else if(not >= 50){
           Console.WriteLine("Notunuz :: DD");
        }
        else if(not >= 40){
           Console.WriteLine("Notunuz :: FD");
        }
        else if(not >= 0){
           Console.WriteLine("Notunuz :: FF");
        }

    }
}
