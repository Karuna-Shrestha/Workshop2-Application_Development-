namespace TASK5;

class Program
{
    static void Main(string[] args)
    {
        // Birthdate
        DateTime birthDate = new DateTime(2005, 12, 22);

        // Current date and time
        DateTime currentDate = DateTime.Now;

        // Calculate age using TimeSpan
        TimeSpan difference = currentDate - birthDate;
        int age = (int)(difference.TotalDays / 365.25);

        // Print details
        Console.WriteLine($"Birthdate: {birthDate:yyyy-MM-dd}");
        Console.WriteLine($"Current Date: {currentDate}");
        Console.WriteLine($"Age: {age} years");

        // Add 10 days to birthdate
        DateTime newDate = birthDate.AddDays(10);

        Console.WriteLine($"Birthdate after 10 days: {newDate:yyyy-MM-dd}");
    }
}