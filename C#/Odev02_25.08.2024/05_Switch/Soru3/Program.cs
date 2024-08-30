namespace Soru3;

class Program
{
    static void Main(string[] args)
    {
        // 3. Kullanıcıdan alınan iki sayı ve bir işlem (+, -, *, /) için basit bir hesap makinesi yapın (switch kullanarak).
        Console.WriteLine("Lutfen bana iki sayi veriniz.");
        int sayi1 = Convert.ToInt32(Console.ReadLine());
        int sayi2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Simdi bu iki sayiya yapmak istediginiz islemi giriniz. (+,-,/,*)");
        char islem = Convert.ToChar(Console.ReadLine());

        switch(islem){
            case '+':
            Console.WriteLine($"Isleminizin sonucu : {sayi1 + sayi2}");
            break;
            case '-':
            Console.WriteLine($"Isleminizin sonucu : {sayi1 - sayi2}");
            break;
            case '/':
            Console.WriteLine($"Isleminizin sonucu : {sayi1 / sayi2}");
            break;
            case '*':
            Console.WriteLine($"Isleminizin sonucu : {sayi1 * sayi2}");
            break;
        }
    }
}
