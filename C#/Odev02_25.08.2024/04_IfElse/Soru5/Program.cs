namespace Soru5;

class Program
{
    static void Main(string[] args)
    {
        // 5. Kullanıcıdan alınan üç sayının bir üçgen oluşturup oluşturamayacağını kontrol eden bir program yazın.
        Console.WriteLine("Lutfen bana sirasiyla a,b ve c olmak uzere 3 adet sayi veriniz.");
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        int c = Convert.ToInt32(Console.ReadLine());

        if(a + b > c || a + c > b || b + c > a){
            Console.WriteLine("Sayilarinizla bir ucgen olusturulabilir!");
        }
        else{
            Console.WriteLine("Sayilarinizla bir ucgen olusturulamaz!");
        }
    }
}
