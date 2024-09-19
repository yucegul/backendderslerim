using System.Dynamic;

namespace Soru02;

class Vehicle
{
    public string Make{get;set;}
    public string Model{get;set;}
    public int Year{get;set;}

    public Vehicle(string make, string model, int year){
    Make = make;
    Model = model;
    Year = year;
}

    public void Goster()
    {
        Console.WriteLine($"Marka= {Make}, Model= {Model}, Yıl= {Year}");
    }

}

class Car:Vehicle{
     public int NumberOfDoors{get;set;}

     public Car(string make, string model, int year, int numberOfDoors)
     : base(make, model,year)
     {
        NumberOfDoors = numberOfDoors;
     }
     public void ArabaOzellik()
    {
        Goster();
        Console.WriteLine($"Kapı Sayısı: {NumberOfDoors}");
    }
}

class Bicycle:Vehicle{
    public bool KornaVarMi{get;set;}
    public Bicycle(string make, string model, int year, bool kornaVarMi)
     : base(make, model,year)
     {
        KornaVarMi = kornaVarMi;
     }
     public void BisikletOzellik()
    {
        Goster();
        Console.WriteLine($"Korna var mı: {(KornaVarMi? "Var" : "Yok")}");
    }
}

class Motorcycle:Vehicle{
    public bool HasSidecar{get; set;}
    public Motorcycle(string make, string model, int year, bool hasSidecar)
     : base(make, model,year)
     {
        HasSidecar = hasSidecar;
     }
     public void MotorOzellik()
    {
        Goster();
        Console.WriteLine($"Yan Sepet Var mı: {(HasSidecar? "Var" : "Yok")}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Bir Vehicle (Taşıt) sınıfı oluşturun. Bu sınıf aşağıdaki özelliklere sahip olmalıdır:
        // Make (marka): Taşıtın markası
        // Model (model): Taşıtın modeli
        // Year (yıl): Taşıtın üretim yılı
        // Bu temel sınıftan Car (Araba), Bicycle (Bisiklet) ve Motorcycle (Motosiklet) sınıflarını türetin.
        // Her taşıt türüne özel bir özellik ekleyin (örneğin, Car için NumberOfDoors (Kapı Sayısı), Motorcycle için HasSidecar (Yan Sepet Var mı)).

        Car araba = new Car("Peugeot", "408", 2023,4);
        Bicycle bisiklet = new Bicycle("Bianchi", "Magma", 2022,true);
        Motorcycle motor = new Motorcycle("Harley Davidson", "V-Rod Muscle", 2013,false);

        araba.ArabaOzellik();
        bisiklet.BisikletOzellik();
        motor.MotorOzellik();
    }
}
