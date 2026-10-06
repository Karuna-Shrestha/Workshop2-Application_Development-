namespace TASK2;

class Circle
{
    public const double PI = 3.14;
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine($"PI = {Circle.PI}");

        // This will give a compilation error because PI is a constant and cannot be changed.
        // Circle.PI = 3.14159;
    }
}