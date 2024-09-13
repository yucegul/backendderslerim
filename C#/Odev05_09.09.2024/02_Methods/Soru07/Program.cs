using System.Security.Cryptography.X509Certificates;

namespace Soru07;

class Program
{
    static void Main(string[] args)
    {
        // 7. Saat, dakika ve saniye alan bir metot yazın. Bu metot zamanı "HH:MM:SS" formatında döndürsün.
        string zaman = SuAn();
        Console.WriteLine(zaman);
    }

    static string SuAn()
    {
        DateTime yeni = DateTime.Now;
        return yeni.ToString("HH:MM:SS");
    }
}
