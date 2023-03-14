using System.Xml.Linq;
using TechTask;

class Program
{
    static void Main(string[] args)
    {
        Triangle triangle = new();
        triangle.InputCoordinates();
        triangle.LengthOfSides();

        if (triangle.isExists())
        {
            if(triangle.isEquilateral())
                Console.WriteLine("Triangle IS 'Equilateral'");
            else 
                Console.WriteLine("Triangle IS NOT 'Equilateral'");

            if (triangle.isIsosceles())
                Console.WriteLine("Triangle IS 'Isosceles'");
            else
                Console.WriteLine("Triangle IS NOT 'Isosceles'");

            if (triangle.isRight())
                Console.WriteLine("Triangle IS 'Right'");
            else
                Console.WriteLine("Triangle IS NOT 'Right'"); 

            Console.WriteLine($"Perimeter : {triangle.Perimeter()}");

            Console.WriteLine("Parity numbers in range from 0 to triangle perimeter:");
            for (int i = 0; i <= triangle.Perimeter(); i += 2)
                Console.WriteLine(i);
        }
        else
            Console.WriteLine("Triangle IS NOT Exists");

    }

    
}