namespace Soru1;

class Program
{
    static void Main(string[] args)
    {
        // 1. Kullanıcıdan alınan bir ondalıklı sayıyı en yakın tam sayıya yuvarlayan bir program yazın.
        Console.WriteLine("Lutfen ondalikli bir sayi giriniz.");
        string deger = Console.ReadLine();
                // Noktali yazinca kabul etmesin
        if(deger.Contains('.')){
            Console.WriteLine("Ondalik kismini girerken nokta degil virgul kullaniniz!");
        }
        else{
        double yenideger = Double.Parse(deger);
        double math = Math.Round(yenideger);
        Console.WriteLine("Sayinizin yuvarlanmis hali: " + math);
        }
    }
}
