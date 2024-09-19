namespace Soru02;

class Calculator
{
    public double Ekleme(double a, double b){
        return a+b;
    }

    public double Cikarma(double a, double b){
        return a-b;
    }

    public double Carpma(double a, double b){
        return a*b;
    }

    public double Bolme(double a, double b){
         if (b == 0)
        {
            throw new DivideByZeroException("Sifira bolme hatasi");
        }
        return a / b;
    }
}

class Bilimsel : Calculator{
    public double Sin(double angle)
    {
        return Math.Sin(angle);
    }

    public double Cos(double angle)
    {
        return Math.Cos(angle);
    }
}




class Program
{
    // Bir Calculator (Hesap Makinesi) sınıfı oluşturun. Bu sınıf aşağıdaki işlemleri gerçekleştiren metodlar içermelidir:

    // Add (Topla)
    // Subtract (Çıkar)
    // Multiply (Çarp)
    // Divide (Böl)
    // Bu sınıftan ScientificCalculator (Bilimsel Hesap Makinesi) türetin ve içine Sin (Sinüs), Cos (Kosinüs) gibi ekstra fonksiyonlar ekleyin.
    static void Main(string[] args)
    {
        Calculator hesap = new Calculator();
        Console.WriteLine(hesap.Bolme(20,5));
    }
}
