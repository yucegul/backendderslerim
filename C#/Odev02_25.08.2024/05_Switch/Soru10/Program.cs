namespace Soru10;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Lutfen bana bir islem ver. (+,-,*,/,%)");
        char islem = Convert.ToChar(Console.ReadLine());
        switch(islem){
            case '+':
            Console.WriteLine("Isleminin adi = Toplama Islemi");
            break;
            case '-':
            Console.WriteLine("Isleminin adi = Cikarma Islemi");
            break;
            case '*':
            Console.WriteLine("Isleminin adi = Carpma Islemi");
            break;
            case '/':
            Console.WriteLine("Isleminin adi = Bolme Islemi");
            break;
            case '%':
            Console.WriteLine("Isleminin adi = Yuzdelik Islem");
            break;
        }
    }
}
