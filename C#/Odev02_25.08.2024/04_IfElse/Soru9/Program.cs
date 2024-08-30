namespace Soru9;

class Program
{
    static void Main(string[] args)
    {
        //  9. Kullanıcıdan alınan iki sayı ve bir işlem (+, -, *, /) için basit bir hesap makinesi yapın.
        Console.WriteLine("Lutfen bana iki sayi veriniz.");
        int sayi1 = Convert.ToInt32(Console.ReadLine());
        int sayi2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Simdi bu iki sayiya yapmak istediginiz islemi veriniz. (+,-,/,*)");
        char islem = Convert.ToChar(Console.ReadLine());
        if(islem == '+'){
           int toplam = sayi1 + sayi2;
           Console.WriteLine(toplam);
        }
        else if(islem == '-'){
           int cikar = sayi1 - sayi2;
           Console.WriteLine(cikar);
        }
        else if(islem == '/'){
           int bol = sayi1 / sayi2;
           Console.WriteLine(bol);
        }
        else if(islem == '*'){
           int carp = sayi1 * sayi2;
           Console.WriteLine(carp);
        }
    }
}
