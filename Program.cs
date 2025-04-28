using StudentSystem;

var miray = new Student()
{
    FirstName = "Miray",
    LastName = "Turgut",
    BirthDate = new DateOnly(2001, 12, 13),
    Gender = "Kadın",
    Kimlik = "23425678945",
    Email =  "miray0853@gmail.com"
}; 
var taner = new Student()
{
    FirstName = "Taner",
    LastName = "Turgut",
    BirthDate = new DateOnly(1967, 11, 20),
    Gender = "Erkek",
    Kimlik = "12370564598",
    Email = "tanerturgut08@hotmail.com"
};
var sebahat =  new Student()
{
    FirstName = "Sebahat",
    LastName = "Turgut",
    BirthDate = new DateOnly(1970, 7, 10),
    Gender = "Kadın",
    Kimlik = "25878940353",
    Email = "sebahatturgut53@mail.com"
};
var ibrahim = new Student()
{
    FirstName = "Ibrahim",
    LastName = "Turgut",
    BirthDate = new DateOnly(1997, 7, 19),
    Gender = "Erkek",
    Kimlik = "90126354933",
    Email = "ibrahimturgutt@gmail.com"
};
var sema = new Student()
{
    FirstName = "Sema",
    LastName = "Turgut",
    BirthDate = new DateOnly(1998, 9, 10),
    Gender = "Kadın",
    Kimlik = "24234546353",
    Email = "semanurturgut3434@gmail.com"
};
var students = new List<Student>{miray, taner, sebahat, ibrahim, sema};
while (true)
{
    Console.Clear();
    Console.WriteLine("Öğrenci Yönetim Sistemi\n".ToUpper());
    Console.WriteLine("Yapmak istediğin işlemi seç:");
    Console.WriteLine("1-Listele");
    Console.WriteLine("2-Ekle");
    Console.WriteLine("3-Sil");
    Console.WriteLine("4-Çıkış");
   var input = Console.ReadLine();
   if (input == "1" && students.Count == 0)
   {
       Console.WriteLine("Şu anda sistemde kayıtlı öğrenci bulunmuyor.");
   }
   else if (input == "1")
   { 
       for (int i = 0; i < students.Count; i++)
       {
           Console.WriteLine(
               $"{students[i].FirstName} {students[i].LastName} {students[i].Gender} {students[i].GetAge()} {students[i].Kimlik} {students[i].Email}");
       }
   }else if (input == "2")
   {Console.Clear();
       Console.WriteLine("Yeni öğrenci ekleme ekranı");

       Console.Write("Adı: ");
       var firstName = Console.ReadLine();

       Console.Write("Soyadı: ");
       var lastName = Console.ReadLine();
       
       Console.Write("Doğum Tarihi (yyyy-MM-dd formatında): ");
       var birthDateInput = Console.ReadLine();
       var birthDate = DateOnly.Parse(birthDateInput);
       
       Console.Write("Cinsiyet (Kadın/Erkek): ");
       var gender = Console.ReadLine();

       Console.Write("Kimlik Numarası: ");
       var kimlik = Console.ReadLine();

       Console.Write("Email: ");
       var email = Console.ReadLine();

       var newStudent = new Student()
       {
           FirstName = firstName,
           LastName = lastName,
           BirthDate = birthDate,
           Gender = gender,
           Kimlik = kimlik,
           Email = email
       };
       students.Add(newStudent);
       Console.WriteLine("Öğrenci başarıyla eklendi!");
   }else if (input == "3")
   {
       Console.Write("Hangi öğrenciyi silmek istersiniz?:");
       var inputStudentToDelete =  int.Parse(Console.ReadLine());
       students.Remove(students[inputStudentToDelete-1]);
   }else if (input == "4")
   {
       Console.Clear();
       Console.WriteLine("Programdan çıkılıyor... Hoşçakal!");
       Thread.Sleep(1000); 
       break;
   }
    Console.WriteLine("\nMenüye dönmek için bir tuşa basın.");
    Console.ReadKey(true);
}















