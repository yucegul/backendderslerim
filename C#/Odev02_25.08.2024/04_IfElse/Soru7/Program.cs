namespace Soru7;

class Program
{
    static void Main(string[] args)
    {
        // 7. Kullanıcıdan alınan üç sayıdan en büyüğünü bulan bir program yazın.
        Console.WriteLine("Lutfen bana 3 sayi veriniz.");
        double sayi1 = Convert.ToDouble(Console.ReadLine());
        double sayi2 = Convert.ToDouble(Console.ReadLine());
        double sayi3 = Convert.ToDouble(Console.ReadLine());
        if(sayi1 > sayi2 && sayi2 > sayi3){
          Console.WriteLine($"En buyuk sayi = {sayi1}");
        }
        else if(sayi1 > sayi3 && sayi3 > sayi2){
           Console.WriteLine($"En buyuk sayi = {sayi1}");
        }
        else if(sayi2 > sayi1 && sayi1 > sayi3){
           Console.WriteLine($"En buyuk sayi = {sayi2}");
        }
        else if(sayi2 > sayi3 && sayi3 > sayi1){
           Console.WriteLine($"En buyuk sayi = {sayi2}");
        }
        else if(sayi3 > sayi1 && sayi1 > sayi2){
           Console.WriteLine($"En buyuk sayi = {sayi3}");
        }
        else if(sayi3 > sayi2 && sayi2 > sayi1){
           Console.WriteLine($"En buyuk sayi = {sayi3}");
        }
        else if(sayi1 == sayi2 && sayi2 > sayi3){
           Console.WriteLine($"En buyuk sayi = {sayi1} ve {sayi2}");
        }
        else if(sayi1 > sayi2 && sayi2 == sayi3){
           Console.WriteLine($"En buyuk sayi = {sayi1}");
        }
        else if(sayi2 > sayi1 && sayi1 == sayi3){
           Console.WriteLine($"En buyuk sayi = {sayi2}");
        }
        else if(sayi3 > sayi1 && sayi1 == sayi2){
           Console.WriteLine($"En buyuk sayi = {sayi3}");
        }
        else if(sayi3 ==  sayi1 && sayi1 > sayi2){
           Console.WriteLine($"En buyuk sayi = {sayi3} ve {sayi1}");
        }
        else if(sayi3 ==  sayi2 && sayi2 > sayi1){
           Console.WriteLine($"En buyuk sayi = {sayi3} ve {sayi2}");
        }
        else{
            Console.WriteLine($"Tum sayilarin esit.");
        }
    }
}
