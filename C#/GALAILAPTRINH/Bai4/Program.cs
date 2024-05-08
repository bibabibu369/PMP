using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Namespace {
    public class Program {
        static void Main(string[] args) {
            const float Pi = 3.14f;
            float r;
            Console.WriteLine("Nhap ban kinh r: ");
            r = float.Parse(Console.ReadLine()??"0");
            Console.WriteLine("Chu vi hinh tron la: " + (2 * r * Pi));
            Console.WriteLine("Dien tich hinh tron la: " + (r * r * Pi));
        }
    }
}