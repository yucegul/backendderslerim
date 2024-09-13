namespace Proje04_24._08._2024;

class Program
{
    static void Main(string[] args)
    { 
        string text1 ="Nişantaşı";
        string text2 ="Üniversitesi";
        string ilce1 ="Bayrampaşa";
        string ilce2 ="Sarıyer";
        string tarih1 ="09.09.2009";
        string tarih2 ="05.05.2018";
        string paragraf = (text1 + " " + text2 + ", " + tarih1 + " " + "tarihinde İstanbul'un " + ilce1 + " ilçesinde faaliyete başladı. Ardından " + tarih2 + " tarihinde yine İstanbul'un " + ilce2 + " ilçesinde kurulan TechCampus'e taşındı.");
        string paragraf2 = $@"{text1} {text2}, {tarih1} tarihinde İstanbul'un {ilce1} ilçesinde faaliyete başladı. Ardından {tarih2} tarihinde yine İstanbul'un {ilce2} ilçesinde kurulan TechCampus'e taşındı.";
        Console.WriteLine(paragraf);
        Console.WriteLine(paragraf2);
    }
}
