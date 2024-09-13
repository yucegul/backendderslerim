
namespace Soru01;

class Program
{
    static void Main(string[] args)
    {
        // 1. Bir kişinin yaşını kontrol eden bir metot yazın. Eğer kişi 65 yaşından büyükse "Emeklilik yaşında", değilse "Çalışma yaşında" şeklinde bir mesaj döndürsün.
        Console.WriteLine("Lutfen yasinizi giriniz.");
        yas();
    }

    static void yas()
    {
        int yas = Convert.ToInt32(Console.ReadLine());
        if(yas > 65){
            Console.WriteLine("Emeklilik yasinda.");
        }
        else{
            Console.WriteLine("Calisma yasinda.");
        }
    }
}
