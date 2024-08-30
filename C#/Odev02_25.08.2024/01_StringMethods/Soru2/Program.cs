namespace Soru2;

class Program
{
    static void Main(string[] args)
    {
        // Kullanıcıdan alınan bir metni tüm harfleri büyük olacak şekilde ve
        //  tüm harfleri küçük olacak şekilde alt alta tek bir Console.Write ile ekrana yazdıran bir program yazın.

        Console.WriteLine("Lutfen bir cumle giriniz.");
        string cumle = Convert.ToString(Console.ReadLine());
        Console.WriteLine("Buyuk harfler ile;");
        Console.WriteLine(cumle.ToUpper());
        Console.WriteLine("Kucuk harfler ile;");
        Console.WriteLine(cumle.ToLower());
    }
}
