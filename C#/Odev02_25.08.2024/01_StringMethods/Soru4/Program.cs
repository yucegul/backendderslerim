namespace Soru4;

class Program
{
    static void Main(string[] args)
    {
        // 4. Kullanıcıdan alınan bir cümlenin başındaki ve sonundaki boşlukları kaldıran bir program yazın.
        Console.WriteLine("Lutfen bir cumle giriniz.");
        string cumle = Console.ReadLine();
        string yenicumle = cumle.Trim();
        Console.WriteLine(yenicumle);
    }
}
