using System.Runtime.InteropServices;

namespace HomeWork_New;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--Ev Odevim--");

        // 1. int tipinde iki değişken oluşturun ve bu değişkenlere değerler atayın. 
        // Sonra bu değişkenleri toplayıp sonucu yeni bir değişkene atayın ve ekrana yazdırın.
        
        Console.WriteLine("1. Madde");
        int sayi1 = 19;
        int sayi2 = 23;
        int toplam = sayi1 + sayi2;
        double degisken = Convert.ToDouble(toplam);
        Console.WriteLine(degisken);

        // 2. double tipinde bir değişken oluşturun ve bu değişkene bir ondalıklı sayı atayın. 
        // Bu sayının karesini hesaplayıp yeni bir double değişkene atayın ve sonucu ekrana yazdırın.
        
        Console.WriteLine("2. Madde");
        double sayi3 = 18.81;
        double kare = sayi3 * sayi3;
        double degisken2 = kare;
        Console.WriteLine(degisken2);
        
        // 3. string tipinde bir değişken oluşturun ve içine adınızı atayın. Sonra int tipinde bir değişken oluşturup yaşınızı atayın.
        //  Bu iki değişkeni kullanarak "Benim adım [ad] ve ben [yaş] yaşındayım." şeklinde bir cümle oluşturup ekrana yazdırın.
        
        Console.WriteLine("3. Madde");
        string isim = "Erdem Yuce";
        int yas = 17;
        Console.WriteLine("Benim adim " + isim + " ve ben " + yas + " yasindayim." );
        
        // 4. char tipinde bir değişken oluşturun ve içine bir harf atayın.
        //  Bu harfin ASCII değerini int tipinde bir değişkene atayıp ekrana yazdırın.
        
        Console.WriteLine("4. Madde");
        char madde4 = Convert.ToChar('X');
        int madde4yeni = madde4;
        Console.WriteLine(madde4yeni);

        // 5. bool tipinde iki değişken oluşturun ve bunlara true ve false değerlerini atayın.
        //  Bu değişkenleri ekrana yazdırın.
        
        Console.WriteLine("5. Madde");
        bool dogruMu = true;
        bool yanlisMi = false;
        Console.WriteLine(dogruMu);
        Console.WriteLine(yanlisMi);
        
        // 6. byte tipinde bir değişken oluşturun ve içine 255 değerini atayın.
        // Sonra bu değeri int tipine dönüştürüp yeni bir değişkene atayın ve ekrana yazdırın.
        
        Console.WriteLine("6. Madde");
        byte madde6 = 255;
        int madde6yeni = Convert.ToInt32(madde6);
        int madde6yeni2 = madde6yeni;
        Console.WriteLine(madde6yeni2);

        // 7. int tipinde bir değişken oluşturun ve içine büyük bir sayı (örneğin 1000000) atayın.
        //  Bu değeri byte tipine dönüştürmeye çalışın. Sonucu ekrana yazdırın ve ne olduğunu açıklayın.

        // Console.WriteLine("7. Madde");
        // int madde7 = 29101923;
        // byte madde7yeni = Convert.ToByte(madde7);
        // Console.WriteLine(madde7yeni);
        // Aldigim hata : "Unhandled exception. System.OverflowException: Value was either too large or too small for an unsigned byte."
        // Degerin bir byte degiskeni icin ya cok buyuk, ya da cok kucuk oldugunu soyluyor.

        // 8. double tipinde bir değişken oluşturun ve içine 3.14 değerini atayın
        // Bu değeri int tipine dönüştürüp yeni bir değişkene atayın ve sonucu ekrana yazdırın. Sonucu yorumlayın.

        Console.WriteLine("8. Madde");
        double madde8 = 3.14;
        int madde8yeni = Convert.ToInt32(madde8);
        Console.WriteLine(madde8yeni);
        // Double degiskeni ile ondalikli bir deger atayabilmekteyiz fakat int turu icin bu kural gecersizdir.

        // 9. string tipinde bir değişken oluşturun ve içine bir sayı yazın (örneğin "42"). 
        // Bu string'i int tipine dönüştürüp yeni bir değişkene atayın ve ekrana yazdırın.
        
        Console.WriteLine("9. Madde");
        string madde9 = "44";
        int madde9yeni = Convert.ToInt32(madde9);
        int madde9yeni2 = madde9yeni;
        Console.WriteLine(madde9yeni2);

        // 10. int tipinde üç değişken oluşturun ve bunlara sırasıyla 5, 10 ve 15 değerlerini atayın.
        // Bu değişkenlerin ortalamasını hesaplayıp double tipinde bir değişkene atayın ve sonucu ekrana yazdırın.

        Console.WriteLine("10. Madde");
        int madde10x = 5;
        int madde10y= 10;
        int madde10z= 15;
        int madde10ortalama = (madde10x + madde10y + madde10z) / 3;
        double madde10yeni = Convert.ToDouble(madde10ortalama);
        Console.WriteLine(madde10yeni);

        // 11. decimal tipinde iki değişken oluşturun ve bunlara para miktarları atayın (örneğin 10.25m ve 5.75m).
        // Bu değerleri toplayıp sonucu yeni bir decimal değişkene atayın ve ekrana yazdırın.

        Console.WriteLine("11. Madde");
        decimal madde11x = 18.81m;
        decimal madde11y = 19.38m;
        decimal madde11toplam = madde11x + madde11y;
        decimal madde11yeni = madde11toplam;
        Console.WriteLine(madde11yeni);
        
        // 12. float tipinde bir değişken oluşturun ve içine 1.23f değerini atayın.
        // Bu değeri double tipine dönüştürüp yeni bir değişkene atayın.
        // İki değeri de ekrana yazdırıp karşılaştırın.

        Console.WriteLine("12. Madde");
        float madde12x = 1.23f;
        double madde12yeni = Convert.ToDouble(madde12x);
        Console.WriteLine(madde12x);
        Console.WriteLine(madde12yeni);
        // float degeri 1,23 sayisini verirken, double degeri ise 1,2300000190734863 sayisini verdi.
        
        // 13. long tipinde bir değişken oluşturun ve içine çok büyük bir sayı atayın, örneğin 500000000000 gibi.
        //  Bu değeri int tipine dönüştürmeye çalışın. Sonucu ekrana yazdırın ve ne olduğunu açıklayın.
        
        // Console.WriteLine("13. Madde");
        // long madde13x = 519188110101938;
        // int madde13yeni = Convert.ToInt32(madde13x);
        // Console.WriteLine(madde13yeni);
        // Madde 7 deki ayni hatayi aldim. Girdigim sayinin bir Int degiskeni icin ya cok buyuk, ya da cok kucuk oldugunu belirtiyor.

        // 14. string tipinde iki değişken oluşturun ve bunlara adınızı ve soyadınızı atayın.
        // Bu iki değişkeni birleştirip yeni bir string değişkene atayın ve ekrana yazdırın.

        Console.WriteLine("14. Madde");
        string madde14x = "Erdem Yuce";
        string madde14y = "Gul";
        string madde14z = madde14x + ' ' + madde14y;
        Console.WriteLine(madde14z);
        
        // 15. string tipinde bir değişken oluşturun ve içine "True" yazın. 
        // Bu string'i bool tipine dönüştürüp yeni bir değişkene atayın ve ekrana yazdırın.
 
        Console.WriteLine("15. Madde");
        string madde15x = "True";
        bool madde15yeni = Convert.ToBoolean(madde15x);
        Console.WriteLine(madde15yeni);

        // 16. double tipinde pi sayısını temsil eden bir değişken oluşturun (3.14159).
        // Bu değeri float tipine dönüştürüp yeni bir değişkene atayın.
        // Her iki değeri de ekrana yazdırıp hassasiyet farkını gözlemleyin.
        
        Console.WriteLine("16. Madde");
        double madde16x = Math.PI;
        float madde16yeni = Convert.ToSingle(madde16x);
        Console.WriteLine(madde16x);
        Console.WriteLine(madde16yeni);
        // double ile aldigim sonuc = 3,141592653589793 iken,
        // float ile aldigim sonuc = 3,1415927

        // 17. byte, short, int, ve long tiplerinde değişkenler oluşturun ve her birine aynı sayısal değeri (örneğin 42) atayın.
        // Bu değişkenlerin bellekte kapladıkları alanı sizeof() operatörünü kullanarak ekrana yazdırın.
        // sizeof() nasıl kullanılır, araştırın.

        Console.WriteLine("17. Madde");
        byte madde17a = 44;
        short madde17b = 44;
        int madde17c = 44;
        long madde17d = 44;
        double madde17e = 44;
        byte madde17asizeof = sizeof(byte);
        short madde17bsizeof = sizeof(short);;
        int madde17csizeof = Marshal.SizeOf(madde17c);
        long madde17dsizeof = sizeof(long);;
        double madde17esizeof = sizeof(double);
        Console.WriteLine(madde17asizeof);
        Console.WriteLine(madde17bsizeof);
        Console.WriteLine(madde17csizeof);
        Console.WriteLine(madde17dsizeof);
        Console.WriteLine(madde17esizeof);
        
        // 18. string tipinde bir değişken oluşturun ve içine bir cümle yazın.
        // Bu cümlenin karakter sayısını int tipinde bir değişkene atayıp ekrana yazdırın. 
        // (İpucu: .Length özelliğini kullanabilirsiniz, araştırın.)
        
        Console.WriteLine("18. Madde");
        string madde18a = "Su an C# odevimi yapmaktayim.";
        int madde18yeni = madde18a.Length;
        Console.WriteLine(madde18yeni);

        // Erdem Yuce Gul, C# Odevim. --23.08.2024--
        
        Console.ReadLine();
    }
}   
