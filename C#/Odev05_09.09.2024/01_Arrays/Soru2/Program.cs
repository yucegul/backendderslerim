namespace Soru2;

class Program
{
    static void Main(string[] args)
    {
        //2. Klavyeden girilen 10 sayıyı bir diziye atayın.
        //Bu sayılardan çift olanları for döngüsü kullanarak ayrı bir diziye aktarın.
        //Ardından bu çift sayı dizisini küçükten büyüğe sıralayın.

        int[] dizi = new int[10];
        int[] cift;
        int cift2 = 0;

        Console.WriteLine("Lutfen 10 adet sayi giriniz");
        for (int i = 0; i < dizi.Length; i++)
        {
            dizi[i] = int.Parse(Console.ReadLine());
        }

        cift = new int[dizi.Length];
        for (int i = 0; i < dizi.Length; i++)
        {
            if (dizi[i] % 2 == 0)
            {
                cift[cift2] = dizi[i];
                cift2++;
            }
        }

        Array.Resize(ref cift, cift2);

        Array.Sort(cift);

        foreach (int sonuc in cift)
        {
            Console.Write(sonuc + " ");
        }
        }
    }
