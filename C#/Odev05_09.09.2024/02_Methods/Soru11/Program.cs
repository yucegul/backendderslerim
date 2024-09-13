
namespace Soru11;

class Program
{
    static void Main(string[] args)
    {
        // 11. Bir kelime alıp, bu kelimenin içinde kaç tane sesli harf bulunduğunu döndüren bir metot yazın.
        string kelime = "helikopter";
        int dondur = Sesli(kelime);
        Console.WriteLine(dondur);
    }

    static int Sesli(string kelime)
    {
        int sesli = 0;
        char[] sesli2 ={'a', 'e', 'i', 'o', 'u','ü','ö','ı','Ö','Ü', 'A', 'E', 'I', 'O', 'U'};
        foreach(char harf in kelime){
           if(Array.Exists(sesli2, sesli3 => sesli3 == harf)){
               sesli++;
           }
        }
        return sesli;
    }
}
