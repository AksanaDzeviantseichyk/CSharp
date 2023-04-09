using System.Drawing;
using System.Text;
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
            Console.WriteLine("3 - to change array values to the right and left of the main diagonal");
            Console.WriteLine("4 - to play the Game of Life");
            Console.WriteLine("Enter the number of the operation you want to execute:");
            
            var numberOfOperation = Console.ReadLine();
            switch (numberOfOperation)
            {
                case "1":
                    splitPhrase();
                    break;
                case "2":
                    swapArrayValues();
                    break;
                case "3":
                    changeArrayValues();
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

    #region case1
    static void splitPhrase()
    {
        Console.WriteLine("Enter the phrase to determine if a word is a palindrome");
        var phrase = Console.ReadLine();
        char[] separators = { ' ', ',', '.', ':', '\t', '–' };
        String[] words = phrase.Split(separators, StringSplitOptions.RemoveEmptyEntries);
        foreach (var word in words)
        {
            if (isPalindrom(word.ToLower()))
                Console.Write($"{word} - palindrom ");
            else Console.WriteLine($"{word} - not palindrom ");
        }
        Console.WriteLine();
        
    }
    static bool isPalindrom(string word)
    {
        for (int i = 0; i < word.Length / 2; i++)
            if (word[i] != word[word.Length - i - 1])
                return false;
        return true;
    }
        #endregion

    #region case2
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
        printArray(array);
       
    }
    #endregion

    #region case3
    static void changeArrayValues()
    {
        Random rnd = new Random();
        int arraySize = rnd.Next(1,10);
        int[,] inputArray = new int[arraySize, arraySize];
        int[,] outputArray = new int[arraySize, arraySize];
        for (int i = 0; i < arraySize; i++)
            for (int j = 0; j < arraySize; j++)
                inputArray[i, j] = rnd.Next(1,10);
        Console.WriteLine("Input array:");
        print2DArray(inputArray);
        for (int i = 0; i < arraySize; i++)
            for (int j = 0; j < arraySize; j++)
                if (j < i)
                    outputArray[i, j] = 0;
                else if (j> i) 
                    outputArray[i, j] = 1;
                    else outputArray[i, j] = inputArray[i,j];
        Console.WriteLine("Output array:");
        print2DArray(outputArray);

    }
    #endregion

    #region case4
    static void gameOflife()
    {

    }
    #endregion

    public static void printArray<T>(T[] array)
    {
        foreach (var item in array)
            Console.Write($"{item}\t");
        Console.WriteLine();
    }
    public static void print2DArray<T>(T[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
                Console.Write($"{matrix[i, j]}\t");
            Console.WriteLine();
        }
    }

}