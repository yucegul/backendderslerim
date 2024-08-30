namespace Soru8;

class Program
{
    static void Main(string[] args)
    {
        // Kullanıcıdan alınan bir sayıya göre (0-6 arası) bir geometrik şeklin adını yazdıran bir program yazın
        //  (0: Nokta, 1: Çizgi, 2: Açı, 3: Üçgen, 4: Kare, 5: Beşgen, 6: Altıgen).
        Console.WriteLine("Lutfen bana bir sayi veriniz.");
        int sayi = Convert.ToInt32(Console.ReadLine());
        switch(sayi){
            case 0:
            Console.WriteLine("Geometrik Seklin : Nokta");
            break;
            case 1:
            Console.WriteLine("Geometrik Seklin : Cizgi");
            break;
            case 2:
            Console.WriteLine("Geometrik Seklin : Aci");
            break;
            case 3:
            Console.WriteLine("Geometrik Seklin : Ucgen");
            break;
            case 4:
            Console.WriteLine("Geometrik Seklin : Kare");
            break;
            case 5:
            Console.WriteLine("Geometrik Seklin : Besgen");
            break;
            case 6:
            Console.WriteLine("Geometrik Seklin : Altigen");
            break;
        }
    }
}
