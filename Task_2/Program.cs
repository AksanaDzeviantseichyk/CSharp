using System.Drawing;
using System.Xml.Linq;

class Program
{
    static void Main(string[] args)
    {
        String answer;
        do
        {
            Console.WriteLine("Choose:");
            Console.WriteLine("1 - to determine if a word is a palindrome");
            Console.WriteLine("2 - to swap the values in the array");
            Console.WriteLine("3 - to change array values ​​to the right and left of the main diagonal");
            Console.WriteLine("4 - to play the Game of Life");
            Console.WriteLine("Enter the number of the operation you want to execute:");
            
            var numberOfOperation = Console.ReadLine();
            switch (numberOfOperation)
            {
                case "1":
                    Console.WriteLine("Enter the word to determine if a word is a palindrome");
                    var wordIsPalindrome = Console.ReadLine();
                    if (isPalindrom(wordIsPalindrome))
                        Console.WriteLine($"{wordIsPalindrome} - palindrom");
                    else Console.WriteLine($"{wordIsPalindrome} - not palindrom");
                    break;
                case "2":
                    swapArrayValues();
                    break;
                case "3":
                    Console.WriteLine("");
                    break;
                case "4":
                    Console.WriteLine("");
                    break;
                default:
                    Console.WriteLine("Unknown operation");
                    break;
            }
            

            Console.WriteLine("Do you want to repeat (YES/NO)? If YES enter Y:");
            answer = Console.ReadLine().ToUpper();

        } while (answer == "Y");
    }

    static bool isPalindrom(string word)
    {
        for (int i = 0; i < word.Length / 2; i++)
            if (word[i] != word[word.Length - i - 1])
                return false;
        return true;
    }
    static void swapArrayValues()
    {
        Console.WriteLine("Enter a size of array:");
        int size = int.Parse(Console.ReadLine());
        int[] array = new int[size];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < array.Length / 2; i++)
        {
            int temp = array[i];
            array[i] = array[array.Length - i - 1];
            array[array.Length - i - 1] = temp;
        }
        Console.WriteLine("Output array:");
        foreach (var item in array)
        {
            Console.Write($"{item.ToString()}  ");
        }
        Console.WriteLine("\n");
    }

}