using System.Security.Cryptography.X509Certificates;

namespace Soru04;

class Book
{
    public string Title{get;set;}
    public string Author{get;set;}
    public int Pages{get;set;}
    public int ISBN{get;set;}
    public bool Borrowed{get; private set;}
    public Book(string title, string author, int pages, int isbn, bool borrowed)
    {
        Title = title;
        Author = author;
        Pages = pages;
        ISBN = isbn;
        Borrowed = false;
    }

    public void Borrow(){
        if(Borrowed){
            Console.WriteLine($"{Title} kitabını ödünç alamazsın çünkü önceden alınmış.");
            
        }
        else{
            Borrowed = true;
            Console.WriteLine($"{Title} kitabını ödünç aldın.");
        }
    }

    public void Return()
    {
        if (!Borrowed)
        {
            Console.WriteLine($"{Title} kitabı zaten iade edilmiş.");
        }
        else
        {
            Borrowed = false;
            Console.WriteLine($"{Title} kitabını iade ettin.");
        }
    }

}

class Library
{
    private List<Book> books = new List<Book>();
}

class Program
{
    static void Main(string[] args)
    {
        // Bir Book (Kitap) sınıfı oluşturun. Bu sınıf aşağıdaki özelliklere sahip olmalıdır:

        //    Title (başlık): Kitap başlığı
        //    Author (yazar): Yazarın adı
        //    Pages (sayfa sayısı): Kitap sayfa sayısı
        //    ISBN (ISBN numarası): Kitap ISBN numarası
        //    Book sınıfına Borrow (Ödünç Al) ve Return (İade Et) metodlarını ekleyin.
        // Daha sonra bir Library (Kütüphane) sınıfı oluşturun ve içinde bir dizi Book nesnesi tutarak bu kitapları yönetebilsin.

    }
}
