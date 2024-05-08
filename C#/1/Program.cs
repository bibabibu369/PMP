using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_1 {
    public class Program
    {
        
        static void Main(string[] args)
        {
            Console.Write("Enter the length of side 1: ");
            double side1 = double.Parse(Console.ReadLine()??"0");

            Console.Write("Enter the length of side 2: ");
            double side2 = double.Parse(Console.ReadLine()??"0");

            Console.Write("Enter the length of side 3: ");
            double side3 = double.Parse(Console.ReadLine()??"0");

            TamGiac triangle = new TamGiac(side1, side2, side3);

            Console.WriteLine($"Chu vi: {triangle.Circumference}");
            Console.WriteLine($"Dien tich: {triangle.DienTich}");
            Console.WriteLine($"Loai tam giac: {triangle.TriangleType}");
        }
    }

    public class TamGiac
    {
        public double Side1 { get; set; }
        public double Side2 { get; set; }
        public double Side3 { get; set; }

        public TamGiac(double side1, double side2, double side3)
        {
            Side1 = side1;
            Side2 = side2;
            Side3 = side3;
        }

        public double Circumference
        {
            get
            {
                return Side1 + Side2 + Side3;
            }
        }

        public double DienTich
        {
            get
            {
                double p = Circumference / 2;
                return Math.Sqrt(p * (p - Side1) * (p - Side2) * (p - Side3));
            }
        }

        public string TriangleType
        {
            get
            {
                if (Side1 == Side2 && Side2 == Side3)
                {
                    return "Tam giac deu";
                }
                else if (Side1 == Side2 || Side1 == Side3 || Side2 == Side3)
                {
                    return "Tam giac can";
                }
                else if (Math.Pow(Side1, 2) + Math.Pow(Side2, 2) == Math.Pow(Side3, 2) ||
                         Math.Pow(Side1, 2) + Math.Pow(Side3, 2) == Math.Pow(Side2, 2) ||
                         Math.Pow(Side2, 2) + Math.Pow(Side3, 2) == Math.Pow(Side1, 2))
                {
                    return "Tam giac vuong";
                }
                else if (Side1 == Side2 && Side2 != Side3 && 2*Math.Pow(Side1, 2) == Math.Pow(Side3, 2))
                {
                    return "Tam giac vuong can";
                }
                else
                {
                    return "Tam giac thuong";
                }
            }
        }
    }
}