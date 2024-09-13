namespace Soru04;

class Program
{
    static void Main(string[] args)
    {
        // 4. Bir öğrencinin vize ve final notlarını alıp, ortalamayı hesaplayarak sonucu döndüren bir metot yazın.
        // (Vize %40, Final %60, Geçme notu 50)
        Console.WriteLine("Lutfen vize notunuzu giriniz.");
        int vize = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Lutfen final notunuzu giriniz.");
        int final = Convert.ToInt32(Console.ReadLine());
        double kontrol = Ortalama(vize, final);

        if (kontrol >= 50){
            Console.WriteLine("Gectiniz");
        }
        else{
            Console.WriteLine("Kaldiniz");
        }
    }

    static double Ortalama(int vize, int final)
    {
        int vize2 = vize * 40/100;
        int final2 = final * 60/100;
        double kontrol = vize2+final2;
        return kontrol;
        
    }
}
