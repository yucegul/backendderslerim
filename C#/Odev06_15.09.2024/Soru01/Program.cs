namespace Soru01;

class Hayvan
{
public string Isim{get; set;}
public int Yas{get; set;}
public string Tur{get; set;}

public Hayvan(string isim, int yas, string tur){
  Isim = isim;
  Yas = yas;
  Tur = tur;
}
    public virtual void MakeSound()
    {
        Console.WriteLine("Ses");
    }
}

class Aslan : Hayvan{
    public Aslan(string isim, int yas) : base(isim,yas,"Aslan")
    {
    }

    public override void MakeSound()
    {
        Console.WriteLine("Kükreme");
    }
}

class Fil : Hayvan{
    public Fil(string isim, int yas) : base(isim,yas,"Fil")
    {
    }

    public override void MakeSound()
    {
        Console.WriteLine("Boru sesi");
    }
}

class Kedi : Hayvan{
    public Kedi(string isim, int yas) : base(isim,yas,"Kedi")
    {
    }

    public override void MakeSound()
    {
        Console.WriteLine("Miyavlama");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Hayvan aslan = new Aslan("Simba", 5);
        Hayvan fil = new Fil("Bobo", 10);
        Hayvan kedi = new Kedi("Cafer", 7);

        aslan.MakeSound();
        fil.MakeSound();
        kedi.MakeSound();

    }
}
