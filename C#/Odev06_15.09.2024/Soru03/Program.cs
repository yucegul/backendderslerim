using System.Security.Cryptography.X509Certificates;

namespace Soru03;

class Employee
{
    public string Name{get;set;}
    public int ID{get;set;}
    public int Salary{get;set;}

    public Employee(string name, int id, int salary){
        Name = name;
        ID = id;
        Salary = salary;
    }

    public void Sonuc()
    {
        Console.WriteLine($"Calisanin adi: {Name} Calisanin ID'si: {ID} Calisanin maasi: {Salary}");
    }
}

class Manager:Employee
{
    public int NumberOfTeams{get;set;}
  public Manager(string name, int id, int salary, int numberOfTeams) : base (name,id,salary)
  {
    NumberOfTeams = numberOfTeams;
  }

  public void ManagerShow(){
     Sonuc();
     Console.WriteLine($"Takim sayisi: {NumberOfTeams}");
  }
}

class Developer:Employee
{
public string ProgrammingLanguage{get;set;}
  public Developer(string name, int id, int salary, string programmingLanguage) : base (name,id,salary)
  {
    ProgrammingLanguage = programmingLanguage;
  }

  public void DeveloperShow(){
     Sonuc();
     Console.WriteLine($"Bildigi diller: {ProgrammingLanguage}");
  }
}

class Intern:Employee
{
  public Intern(string name, int id, int salary) : base (name,id,salary)
  {
  }

  public void InternShow(){
     Sonuc();
  }
}

class Program
{
    static void Main(string[] args)
    {
        // Bir Employee (Çalışan) sınıfı oluşturun. Bu sınıf aşağıdaki özelliklere sahip olmalıdır:
        // Name (isim): Çalışanın adı
        // Id (kimlik numarası): Çalışanın kimlik numarası
        // Salary (maaş): Çalışanın maaşı
        // Employee sınıfından Manager (Yönetici), Developer (Geliştirici) ve Intern (Stajyer) sınıflarını türetin.
        //  Manager sınıfına ek olarak NumberOfTeams (Takım Sayısı) özelliğini, Developer sınıfına ise ProgrammingLanguage (Programlama Dili) özelliğini ekleyin.
      
      Manager yonetici = new Manager("Yuce",451,150000,5);
      Developer gelistirici = new Developer("Erdem",714,100000,"C#, Java, JavaScript, .NET, Python, Angular, Blazor");
      Intern ogrenci = new Intern("Gul",1118,40000);
      

      yonetici.ManagerShow();
      gelistirici.DeveloperShow();
      ogrenci.InternShow();
    }
}
