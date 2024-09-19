namespace Soru09;

class Account
{
    public int AccountNumber{get; set;}
    public decimal Balance{get;set;}
    
    public Account(int accountNumber, decimal balance)
    {
        AccountNumber = accountNumber;
        Balance = balance;
    }

    public void ParaYatir(decimal miktar){
        Balance += miktar;
        Console.WriteLine($"{AccountNumber} hesabına {miktar} lira yatırıldı.");
    }

    public void ParaCek(decimal miktar){
        if(miktar < Balance){
           Balance -= miktar;
           Console.WriteLine($"{AccountNumber} hesabından {miktar} lira çekildi. Yeni bakiye: {Balance}");
        }
        else{
            Console.WriteLine($"Yetersiz bakiye!");
        }
        
    }
}

class SavingsAccount : Account
{
    public SavingsAccount(int accountNumber, decimal balance) : base (accountNumber,balance)
    {
    }

    public void Check(decimal miktar)
    {
        if(miktar < Balance){
            Balance -= miktar;
            Console.WriteLine($"{AccountNumber} hesabından {miktar} lira çekildi. Yeni bakiye: {Balance}");
        }
        else{
            Console.WriteLine($"Yetersiz bakiye!");
        }
    }
   
}

class CheckingAccount : Account
{
public CheckingAccount(int accountNumber, decimal balance) : base (accountNumber,balance)
    {
    }

    public void Check(decimal miktar)
    {
        if(miktar < Balance){
            Balance -= miktar;
            Console.WriteLine($"{AccountNumber} hesabından {miktar} lira çekildi. Yeni bakiye: {Balance}");
        }
        else{
            Console.WriteLine($"Yetersiz bakiye!");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Bir Account (Hesap) temel sınıfı oluşturun. Bu sınıf aşağıdaki özelliklere sahip olmalıdır:
        // AccountNumber (Hesap Numarası): Hesap numarası
        // Balance (Bakiye): Hesap bakiyesi
        // Bu sınıftan SavingsAccount (Tasarruf Hesabı) ve CheckingAccount (Vadesiz Hesap) sınıflarını türetin.
        // Her hesap türüne özgü işlemler (örneğin, CheckingAccount için WriteCheck (Çek Yaz)) ekleyin.

        SavingsAccount saac = new SavingsAccount(451714, 7485677);
        saac.ParaYatir(4000);
        saac.Check(20000);
        CheckingAccount chac = new CheckingAccount(111817, 14125655);
        saac.ParaCek(560000);
        saac.Check(100000);
    }
}
