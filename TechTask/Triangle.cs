using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechTask
{
    public class Triangle
    {
        private double lengthAB;
        private double lengthBC;
        private double lengthAC;
        public Triangle(Point A, Point B, Point C)
        {
            lengthAB = Math.Sqrt(Math.Pow((B.getsetX - A.getsetX), 2) + Math.Pow((B.getsetY - A.getsetY), 2));
            lengthBC = Math.Sqrt(Math.Pow((C.getsetX - B.getsetX), 2) + Math.Pow((C.getsetY - B.getsetY), 2));
            lengthAC = Math.Sqrt(Math.Pow((C.getsetX - A.getsetX), 2) + Math.Pow((C.getsetY - A.getsetY), 2));
        }
        public void LengthOfSides()
        {
            Console.WriteLine($"Length of AB is:{lengthAB}");
            Console.WriteLine($"Length of BC is:{lengthBC}");
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
