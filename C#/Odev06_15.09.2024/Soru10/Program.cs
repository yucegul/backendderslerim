using System.Runtime;

namespace Soru10;

class Character{
    public string Name{get;set;}
    public int Health{get;set;}
    public Character(string name, int health){
       Name = name;
       Health = health;
    }
    public void Heal(int heal)
    {
        Health += heal;
        Console.WriteLine($"{Name} {heal} can aldı. Kalan can: {Health}");
    }
    public void Hasar(int hasar)
    {
        Health -= hasar;
        Console.WriteLine($"{Name} {hasar} hasar aldı. Kalan can: {Health}");

        if(Health <= 0 ){
           Console.WriteLine($"{Name} öldü!");
        }
    }
}

class Warrior : Character{
   public Warrior(string name, int health) : base(name,health)
   {
   }

   public void SwordCharge(Character target){
       int hasar = 30;
       target.Hasar(hasar);
   }
}

class Mage : Character{
public Mage(string name, int health) : base(name,health)
   {
   }
   public void DarkSpell(Character target){
       int hasar = 40;
       target.Hasar(hasar);
   }
}

class Medic : Character{
public Medic(string name, int health) : base(name,health)
   {
   }
   public void Heal(Character target){
    int heal = 35;
    target.Heal(heal);
   }
}
class Program
{
    static void Main(string[] args)
    {
        // Bir Character (Karakter) sınıfı oluşturun. Bu sınıf aşağıdaki özelliklere sahip olmalıdır:
        // Name (isim): Karakter adı
        // Health (sağlık): Karakterin sağlığı
        // Bu sınıftan Warrior (Savaşçı), Mage (Büyücü) ve Archer (Okçular) sınıflarını türetin.
        // Her türemiş sınıfa spesifik saldırı yetenekleri ekleyin (örneğin, Warrior için SwordAttack (Kılıç Saldırısı), Mage için CastSpell (Büyü Atma)).

        Warrior warrior = new Warrior("Aragorn", 100);
        Mage mage = new Mage("Gandalf", 150);
        Medic medic = new Medic ("Galadriel", 120);

        mage.DarkSpell(warrior);
        warrior.SwordCharge(mage);
        mage.DarkSpell(warrior);
        medic.Heal(warrior);
        warrior.SwordCharge(mage);
        mage.DarkSpell(warrior);
        mage.DarkSpell(warrior);
    }
}
