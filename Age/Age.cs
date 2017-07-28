using System;

class Age
{
    static void Main()
    {
        DateTime birthday = DateTime.ParseExact(Console.ReadLine(),"MM.dd.yyyy", null);
        DateTime currentday = DateTime.Today;
        int age = currentday.Year - birthday.Year;
        if (birthday > currentday.AddYears(-age))
        {
            age--;
        }
        Console.WriteLine(age);
        Console.WriteLine(age + 10);
    }
}
