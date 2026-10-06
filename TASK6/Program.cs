namespace TASK6;

class Program
{
    static void Main(string[] args)
    {
        // Create a List containing 3 fruits
        List<string> fruits = new List<string>
        {
            "Mango",
            "Apple",
            "Banana"
        };

        // Add a new fruit
        fruits.Add("Orange");

        // Remove one fruit
        fruits.Remove("Banana");

        // Print all fruits using foreach
        Console.WriteLine("Fruits in the list:");

        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }

        // Create a Dictionary with fruit IDs and names
        Dictionary<int, string> fruitDictionary = new Dictionary<int, string>
        {
            { 1, "Mango" },
            { 2, "Apple" },
            { 3, "Orange" }
            
        };

        // Add a new entry
        fruitDictionary.Add(4, "Grapes");

        // Print all key-value pairs
        Console.WriteLine("\nFruit Dictionary:");

        foreach (KeyValuePair<int, string> item in fruitDictionary)
        {
            Console.WriteLine($"ID: {item.Key}, Fruit: {item.Value}");
        }
    }
}