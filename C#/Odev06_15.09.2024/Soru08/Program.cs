namespace Soru08;

class Person
{
    public string Name{get;set;}
    public int Age{get;set;}

    public Person(string name, int age)
    {
       Name = name;
       Age = age;
    }

    public void Sonuc()
    {

    }
}

class Teacher : Person
{
   public string SubjectTaught{get;set;}

   public Teacher(string name, int age, string subjectTaught) : base(name,age)
   {
        SubjectTaught = subjectTaught;
   }

   public virtual void AttendClass()
    {
        Console.WriteLine($"{Name} öğretmen {SubjectTaught} dersine giriyor...");
    }
}

class Student : Person
{
  public int GradeLevel{get;set;}

   public Student(string name, int age, int gradeLevel) : base(name,age)
   {
        GradeLevel = gradeLevel;
   }
   public virtual void AttendClass()
    {
        Console.WriteLine($"{Name} öğrenci {GradeLevel}. sınıf dersine giriyor...");
    }
}
class Program
{
    static void Main(string[] args)
    {
        // Bir Person (Kişi) sınıfı oluşturun. Bu sınıf aşağıdaki özelliklere sahip olmalıdır:
        // Name (isim): Kişinin adı
        // Age (yaş): Kişinin yaşı
        // Bu sınıftan Teacher (Öğretmen) ve Student (Öğrenci) sınıflarını türetin. Teacher sınıfına SubjectTaught (Öğrettiği Konu),
        // Student sınıfına ise GradeLevel (Sınıf Seviyesi) özelliğini ekleyin.
        // Her iki sınıfa da AttendClass (Derse Katıl) metodunu ekleyin, ancak bu metod her sınıfta farklı çalışsın.

        Teacher teacher = new Teacher("Ali", 45, "Matematik");
        teacher.AttendClass();

        Student student = new Student("Mehmet", 16, 10);
        student.AttendClass();
    }
}
