namespace Soru07;

class Product{
    public string Name{get;set;}
    public int Price{get;set;}
    public int StockQuantity{get;set;}

    public Product(string name, int price, int stockquantity){
        Name = name;
        Price = price;
        StockQuantity = stockquantity;
    }

    public void Kontrol(){
        if(StockQuantity > 0){
           Console.WriteLine($"{Name} ürününden {StockQuantity} adet var.");
        }
        else
        {
            Console.WriteLine($"{Name} stokta mevcut değil.");
        }
    }

    public void Guncelle(int miktar){
        StockQuantity += miktar;
        Console.WriteLine($"{Name} ürününden {StockQuantity} adet daha eklendi.");
    }
}

class FoodProduct : Product{
   public DateTime ExpirationDate{get;set;}

   public FoodProduct(string name, int price, int stockquantity, DateTime expiration) : base (name, price, stockquantity)
   {
     ExpirationDate = expiration;
   }

   public void FoodSonuc()
   {
      Console.WriteLine($"Son kullanma tarihi : {ExpirationDate}");
   }
}

class ElectronicProduct : Product{
   public string Marka{get;set;}

      public ElectronicProduct(string name, int price, int stockquantity, string marka) : base (name, price, stockquantity)
      {
        Marka = marka;
      }

      public void ElectroSonuc()
      {  
        Console.WriteLine($"Ürünün Markası : {Marka}");
      }
}

class Program
{
    static void Main(string[] args)
    {
        // Bir Product (Ürün) sınıfı oluşturun. Bu sınıf aşağıdaki özelliklere sahip olmalıdır:
        // Name (isim): Ürün adı
        // Price (fiyat): Ürün fiyatı
        // StockQuantity (stok miktarı): Ürün stok miktarı
        // Product sınıfına CheckStock (Stoku Kontrol Et) ve UpdateStock (Stok Güncelle) metodlarını ekleyin.
        // FoodProduct (Gıda Ürünü) ve ElectronicProduct (Elektronik Ürün) gibi türemiş sınıflar oluşturun ve her sınıfa spesifik özellikler ekleyin
        // (örneğin, FoodProduct için ExpirationDate (Son Kullanma Tarihi)).

        FoodProduct food = new FoodProduct("Meyve", 20, 5000, DateTime.Now.AddMonths(1));
        food.Kontrol();
        food.FoodSonuc();

        ElectronicProduct electro = new ElectronicProduct("Kulaklık", 5000, 20, "Marshall");
        electro.Guncelle(10);
        electro.ElectroSonuc();




    }
}
