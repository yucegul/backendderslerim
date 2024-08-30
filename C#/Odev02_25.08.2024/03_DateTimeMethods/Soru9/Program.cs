namespace Soru9;

class Program
{
    static void Main(string[] args)
    {
        // 9. Kullanıcıdan alınan bir tarihin, başka bir kullanıcıdan alınan tarihten önce mi, sonra mı yoksa aynı mı olduğunu kontrol eden bir program yazın.
        Console.WriteLine("Lutfen bana bir tarih verin.");
        DateTime tarih = Convert.ToDateTime(Console.ReadLine());
        DateTime XKullanicisindanAlinanTarih = Convert.ToDateTime("25/12/2006");
        if(tarih > XKullanicisindanAlinanTarih){
          Console.WriteLine($"Girdigin tarih x kullanicisinin girdigi tarihinden ({XKullanicisindanAlinanTarih}) sonra!");
        }
        else{
            Console.WriteLine($"Girdigin tarih x kullanicisinin girdigi tarihinden ({XKullanicisindanAlinanTarih}) once!");
        }
    }
}
