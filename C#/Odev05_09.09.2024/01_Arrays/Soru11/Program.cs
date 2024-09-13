namespace Soru11;

class Program
{
    static void Main(string[] args)
    {
        // 11. Klavyeden girilen bir cümlenin kelimelerini bir diziye aktarın.
        //  while döngüsü ile bu kelimeleri tersten ekrana yazdırın.
        Console.WriteLine("Lutfen bir cumle giriniz.");
        string cumle = Console.ReadLine();
        string[] kelime = cumle.Split(' ');
        int i = kelime.Length - 1;
        while (i>=0){
            Console.Write(kelime[i] + " ");
            i--;
        }
    }
}
