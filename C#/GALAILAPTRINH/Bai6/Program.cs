using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Namespace {
    public class Program {
        static void Main(string[] args) {
            /*
            float tong;
            float hieu;
            Console.WriteLine("Nhap vao tong: ");
            tong = float.Parse(Console.ReadLine()??"0");
            Console.WriteLine("Nhap vao hieu: ");
            hieu = float.Parse(Console.ReadLine()??"0");

            float y = (tong + hieu) / 2;
            float x =  tong - y;
            Console.WriteLine("So x can tim la: " + x);
            Console.WriteLine("So y can tim la: " + y);
            */
            float chieuCao;
            float canNang;

            Console.WriteLine("Nhap vao can nang: ");
            canNang = float.Parse(Console.ReadLine()??"0");
            Console.WriteLine("Nhap vao chieu cao: ");
            chieuCao = float.Parse(Console.ReadLine()??"0");
            
            float BMI = canNang / (float)Math.Pow(chieuCao, 2);

            if (BMI < 15) {
                Console.WriteLine("Than hinh qua gay");
            }
            else if (BMI < 16) {
                Console.WriteLine("Than hinh gay");
            }
            else if (BMI < 18.5) {
                Console.WriteLine("Than hinh hoi gay");
            }
            else if (BMI < 25) {
                Console.WriteLine("Than hinh binh thuong");
            }  
            else if (BMI < 30) {
                Console.WriteLine("Than hinh hoi beo");
            }
            else if (BMI < 35) {
                Console.WriteLine("Than hinh beo phi cap do 1");
            }
            else {
                Console.WriteLine("Than hinh beo vll");
            }
        }
    }
}