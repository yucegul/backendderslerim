
using Microsoft.Win32;

namespace Soru03;

class Program
{
    static void Main(string[] args)
    {
        // 3. Parametre olarak bir kelime alıp, bu kelimeyi tersine çevirerek geri döndüren bir metot yazın.
        Console.WriteLine("Lutfen bir kelime giriniz.");
        kelime();
    }

    static void kelime()
    {
        string ifade = Console.ReadLine();
        char[] harf = ifade.ToCharArray();
        Array.Reverse(harf);
        string yeni = new string(harf);
        Console.WriteLine(yeni);
    }
}
