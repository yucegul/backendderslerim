namespace Soru3;

class Program
{
    static void Main(string[] args)
    {
        // 3. Kullanıcıdan alınan bir cümlede belirli bir kelimenin kaç kez geçtiğini bulan bir program yazın.
        Console.WriteLine("Lutfen icinde 'elma' kelimesi birden cok gecen bir cumle kurunuz!");
        string cumle = Console.ReadLine();
        string[] kelime = cumle.Split("elma");
        Console.WriteLine(kelime.Length - 1);
    }
}
