using System.Security.Cryptography.X509Certificates;

namespace Soru05;

class Event
{
   public string Name{get;set;}
   public DateTime Date{get;set;}
   public string Location{get;set;}

   public Event(string name, DateTime date, string location)
   {
      Name = name;
      Date = date;
      Location = location;
   }

   public void Sonuc(){
    Console.WriteLine($"Etkinliğin adı: {Name} Etkinliğin tarihi: {Date} Etkinliğin konumu: {Location}");
   }
}

class Meeting : Event{
   public string MeetingChairman{get;set;}

   public Meeting(string name, DateTime date, string location, string chairman) : base(name,date,location)
   {
    MeetingChairman = chairman;
   }

   public void ChairmanResult()
   {
    Console.WriteLine($"Toplantının başkanı: {MeetingChairman}");
   }
}

class Birthday : Event{
    public string DogumGunu{get;set;}

    public Birthday(string name, DateTime date, string location, string dogumgunu) : base(name,date,location)
    {
        DogumGunu = dogumgunu;
    }

    public void Dogum()
    {
        Console.WriteLine($"{DogumGunu} kişisinin doğum günü kutlandı!");
    }

}

class Task : Event{
   public bool MarkAsComplete{get;private set;}
   public Task(string name, DateTime date, string location) : base(name, date, location)
   {
      MarkAsComplete = false;
   }

   public void Complete(){
    MarkAsComplete = true;
    Console.WriteLine($"Görev Tamamlandı!");
   }
}

class Program
{
    static void Main(string[] args)
    {
        // Bir Event (Etkinlik) sınıfı oluşturun. Bu sınıf aşağıdaki özelliklere sahip olmalıdır:
         //  Name (isim): Etkinlik adı
         //  Date (tarih): Etkinlik tarihi
         //  Location (yer): Etkinlik yeri
         //  Bu sınıftan Meeting (Toplantı), Birthday (Doğum Günü) ve Task (Görev) gibi farklı etkinlik sınıfları türetin.
        // Her bir etkinlik türüne özel bir metod ekleyin (örneğin, Task için MarkAsComplete (Tamamlandı Olarak İşaretle)).

        Meeting meeting = new Meeting("İş Toplantısı", DateTime.Now.AddDays(2), "İkitelli Ofis", "Mehmet");
        meeting.Sonuc();
        meeting.ChairmanResult();

        Birthday birthday = new Birthday("Ali'nin doğum günü", DateTime.Now.AddMonths(2), "Polonezköy", "Ali");
        birthday.Sonuc();
        birthday.Dogum();

        Task task = new Task("Çöpleri çıkar", DateTime.Now, "Ev");
        task.Sonuc();
        task.Complete();

    }
}
