using System.Xml.Linq;
using TechTask;

class Program
{
    static void Main(string[] args)
    {
        String answer;
        do
        {
            Point A = new();
            Point B = new();
            Point C = new();
            try
            {
                Console.WriteLine("Enter coordinate x of dot A:");
                A.getsetX = Double.Parse(Console.ReadLine());
                Console.WriteLine("Enter coordinate y of dot A:");
                A.getsetY = Double.Parse(Console.ReadLine());
                Console.WriteLine("Enter coordinate x of dot B:");
                B.getsetX = Double.Parse(Console.ReadLine());
                Console.WriteLine("Enter coordinate y of dot B:");
                B.getsetY = Double.Parse(Console.ReadLine());
                Console.WriteLine("Enter coordinate x of dot C:");
                C.getsetX = Double.Parse(Console.ReadLine());
                Console.WriteLine("Enter coordinate y of dot C:");
                C.getsetY = Double.Parse(Console.ReadLine());
            }
            catch (Exception ex) 
            {
                Console.WriteLine($"Exception: {ex.Message}");
                Console.WriteLine($"Method: {ex.TargetSite}");
                
            }

            Triangle triangle = new(A, B, C);

            if (triangle.isExists())
            {
                triangle.LengthOfSides();

                if (triangle.isEquilateral())
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

            Console.WriteLine("Do you want to repeat (YES/NO)? If YES enter Y:");
            answer = Console.ReadLine().ToUpper();

        } while (answer == "Y");
       

    }

    
}