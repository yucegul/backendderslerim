using System.Collections;
using System.Threading.Tasks.Dataflow;

namespace Soru05;

class Program
{
    static void Main(string[] args)
    {
        // 5. Bir string dizisindeki tüm isimleri büyük harfe çeviren bir metot yazın.
        string[] dizi = ["ali" , "ata", "mehmet", "yuce", "haluk", "erdem"];
        string[] dizicevir = Dizi2(dizi);

        for(int i = 0; i<dizi.Length;i++){
           Console.WriteLine(dizi[i]);
        }
        
    }

    static string[] Dizi2(string[] dizi)
    {
        for (int i = 0; i < dizi.Length; i++)
        {
            dizi[i] = dizi[i].ToUpper();
        }
        return dizi;
    }
}
