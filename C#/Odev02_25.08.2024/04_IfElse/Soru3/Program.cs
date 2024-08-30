namespace Soru3;

class Program
{
    static void Main(string[] args)
    {
        // 3. Kullanıcıdan alınan bir karakterin sesli harf olup olmadığını kontrol eden bir program yazın. (Veya (||) operatörünü araştırınız.)
        Console.WriteLine("Lutfen bana 1 adet harf veriniz.");
        char harf = Convert.ToChar(Console.ReadLine());
        if(harf == 'a' || harf == 'e' || harf == 'u' || harf == 'ü' || harf == 'o' || harf == 'ö'|| harf == 'ı'|| harf == 'i'){
            Console.WriteLine("Harfiniz sesli bir harftir.");
        }
        else{
            Console.WriteLine("Harfiniz sessiz bir harftir.");
        }
    }
}
