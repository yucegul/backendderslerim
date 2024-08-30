namespace Soru2;

class Program
{
    static void Main(string[] args)
    {
        // 2. Kullanıcıdan alınan üç sayıyı büyükten küçüğe sıralayan bir program yazın.
        Console.WriteLine("Lutfen 3 adet sayi giriniz.");
        double sayi1 = Convert.ToDouble(Console.ReadLine());
        double sayi2 = Convert.ToDouble(Console.ReadLine());
        double sayi3 = Convert.ToDouble(Console.ReadLine());
        if(sayi1 > sayi2 && sayi2 > sayi3){
          Console.WriteLine($"{sayi1} > {sayi2} > {sayi3}");
        }
        else if(sayi1 > sayi3 && sayi3 > sayi2){
           Console.WriteLine($"{sayi1} > {sayi3} > {sayi2}");
        }
        else if(sayi2 > sayi1 && sayi1 > sayi3){
           Console.WriteLine($"{sayi2} > {sayi1} > {sayi3}");
        }
        else if(sayi2 > sayi3 && sayi3 > sayi1){
           Console.WriteLine($"{sayi2} > {sayi3} > {sayi1}");
        }
        else if(sayi3 > sayi1 && sayi1 > sayi2){
           Console.WriteLine($"{sayi3} > {sayi1} > {sayi2}");
        }
        else if(sayi3 > sayi2 && sayi2 > sayi1){
           Console.WriteLine($"{sayi3} > {sayi2} > {sayi1}");
        }
        else if(sayi1 == sayi2 && sayi2 > sayi3){
           Console.WriteLine($"{sayi1} = {sayi2} > {sayi3}");
        }
        else if(sayi1 > sayi2 && sayi2 == sayi3){
           Console.WriteLine($"{sayi1} > {sayi2} == {sayi3}");
        }
        else if(sayi2 > sayi1 && sayi1 == sayi3){
           Console.WriteLine($"{sayi2} > {sayi1} == {sayi3}");
        }
        else if(sayi3 > sayi1 && sayi1 == sayi2){
           Console.WriteLine($"{sayi3} > {sayi1} == {sayi2}");
        }
        else if(sayi3 ==  sayi1 && sayi1 > sayi2){
           Console.WriteLine($"{sayi3} == {sayi1} > {sayi2}");
        }
        else if(sayi3 ==  sayi2 && sayi2 > sayi1){
           Console.WriteLine($"{sayi3} == {sayi2} > {sayi1}");
        }
        else{
            Console.WriteLine($"{sayi1} = {sayi2} = {sayi3}");
        }
    }   
}
