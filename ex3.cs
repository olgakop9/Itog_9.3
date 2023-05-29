using System;
using System.Linq;
class Program
{
    static void Main()
    {
        string[] originalArray = { "Hello123", "World456", "Today is 2023.05.21" };
        string[] newArray = originalArray.Select(s => new string(s.Where(c => !char.IsDigit(c)).ToArray())).ToArray();
        Console.WriteLine(string.Join(", ", newArray));
    }
}