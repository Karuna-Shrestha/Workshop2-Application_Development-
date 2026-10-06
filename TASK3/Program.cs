namespace TASK3;

class Program
{
    static void Main(string[] args)
    {
        byte myByte = 10;
        short myShort = 20;
        int myInt = 42;
        long myLong = 100000;
        float myFloat = 3.14f;
        double myDouble = 3.14159;
        decimal myDecimal = 99.99m;
        char myChar = 'A';
        bool myBool = true;

        // Integer to String
        string numberString = myInt.ToString();

        // String to Double
        double convertedDouble = double.Parse("3.14");

        Console.WriteLine($"byte: {myByte}");
        Console.WriteLine($"short: {myShort}");
        Console.WriteLine($"int: {myInt}");
        Console.WriteLine($"long: {myLong}");
        Console.WriteLine($"float: {myFloat}");
        Console.WriteLine($"double: {myDouble}");
        Console.WriteLine($"decimal: {myDecimal}");
        Console.WriteLine($"char: {myChar}");
        Console.WriteLine($"bool: {myBool}");
        Console.WriteLine($"Integer to String: {numberString}");
        Console.WriteLine($"String to Double: {convertedDouble}");
    }
}