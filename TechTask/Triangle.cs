using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechTask
{
    public class Triangle
    {
        private double Xa;
        private double Ya;
        private double Xb;
        private double Yb;
        private double Xc;
        private double Yc;
        private double lengthAB;
        private double lengthBC;
        private double lengthAC;

        public void InputCoordinates()
        {
            Console.WriteLine("Enter coordinate x of dot A:");
            Xa = Double.Parse(Console.ReadLine());
            Console.WriteLine("Enter coordinate y of dot A:");
            Ya = Double.Parse(Console.ReadLine());
            Console.WriteLine("Enter coordinate x of dot B:");
            Xb = Double.Parse(Console.ReadLine());
            Console.WriteLine("Enter coordinate y of dot B:");
            Yb = Double.Parse(Console.ReadLine());
            Console.WriteLine("Enter coordinate x of dot C:");
            Xc = Double.Parse(Console.ReadLine());
            Console.WriteLine("Enter coordinate y of dot C:");
            Yc = Double.Parse(Console.ReadLine());

        }

        public void LengthOfSides()
        {
            lengthAB = Math.Sqrt(Math.Pow((Xb - Xa), 2) + Math.Pow((Yb - Ya), 2));
            Console.WriteLine($"Length of AB is:{lengthAB}");
            lengthBC = Math.Sqrt(Math.Pow((Xc - Xb), 2) + Math.Pow((Yc - Yb), 2));
            Console.WriteLine($"Length of BC is:{lengthBC}");
            lengthAC = Math.Sqrt(Math.Pow((Xc - Xa), 2) + Math.Pow((Yc - Ya), 2));
            Console.WriteLine($"Length of AC is:{lengthAC}");
        }

        public bool isExists()
        {
            if (lengthAB + lengthBC > lengthAC && lengthAB + lengthAC > lengthBC && lengthBC + lengthAC > lengthAB)
                return true;
            return false;
        }

        public bool isEquilateral()
        {
            if (lengthAB == lengthBC && lengthAB == lengthAC && lengthBC == lengthAC)
                return true;
            return false;
        }

        public bool isIsosceles()
        {
            if(lengthAB == lengthBC || lengthAB == lengthAC || lengthBC == lengthAC) 
                return true;
            return false;
        }

        public bool isRight()
        {
            double delta = 0.01;
            double maxSide;
            maxSide = Math.Max(lengthAC, Math.Max(lengthBC, lengthAB));
            if (maxSide == lengthAC)
            {
                if (Math.Abs(Math.Pow(lengthAC,2)-(Math.Pow(lengthBC,2)+Math.Pow(lengthAB,2)))<= delta) return true;
                return false;
            }
            if (maxSide == lengthAB)
            {
                if (Math.Abs(Math.Pow(lengthAB, 2) - (Math.Pow(lengthBC, 2) + Math.Pow(lengthAC, 2))) <= delta) return true;
                return false;
            }
            if (maxSide == lengthBC)
            {
                if (Math.Abs(Math.Pow(lengthBC, 2) - (Math.Pow(lengthAB, 2) + Math.Pow(lengthAC, 2))) <= delta) return true;
                return false;
            }
            return false;
        }

        public double Perimeter()
        {
            return lengthAB + lengthBC + lengthAC;
        }
    }
}
