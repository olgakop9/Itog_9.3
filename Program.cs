//Написать программу, которая из сформированного массива строк содержащих символы и числа создать массив из строк, 
//в который попадут только символы, не являющиеця цифрами.
//Входные данные можно получить путём ввода с клавиатуры, но лучше сделать автогенерацию данных. При решении не использовать "читерство".

using System;
using System.Linq;
class Program
{
    public Program()
    {
    }

    static void Main()
    {
        string[] originalArray = { "Hello123", "World456", "Today is 2023.05.21" };
        string[] newArray = originalArray.Select(s => new string(s.Where(c => !char.IsDigit(c)).ToArray())).ToArray();
        Console.WriteLine(string.Join(", ", newArray));
    }
}