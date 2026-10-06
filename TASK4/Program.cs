namespace TASK4;

class Program
{
    static void Main(string[] args)
    {
        // Create an integer array with 5 favorite numbers
        int[] numbers = { 4, 3, 2, 1, 5 };

        // Sort the array in ascending order
        Array.Sort(numbers);

        // Reverse the sorted array
        Array.Reverse(numbers);

        // Print each element using for loop
        Console.WriteLine("Array elements:");

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(numbers[i]);
        }

        // Find the position of a specific number
        int numberToFind = 5;
        int position = Array.IndexOf(numbers, numberToFind);

        Console.WriteLine($"Position of {numberToFind}: {position}");
    }
}