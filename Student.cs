namespace StudentSystem;

public class Student
{
    public string FirstName { get; set; } // ad
    public string LastName { get; set; } // soyad
    public DateOnly BirthDate { get; set; } // yaş
    public string Gender { get; set; }
    public string  Kimlik { get; set; }
    public string Email { get; set; }

    public int GetAge()
    {
        return CalculateAge();
    }

    private int CalculateAge()
    {
        var today = DateOnly.FromDateTime(DateTime.Now);
        var age = today.Year - BirthDate.Year;
        if (today < BirthDate.AddYears(age))
        {
            age--;
        }

        return age;
    }
}