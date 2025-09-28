using System;
using System.Collections.Generic;
using System.Text;
using DLL;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap chuoi bat ky");
            string input = Console.ReadLine();

            Class1 calc = new Class1();
            calc.Input = input;
            string report = calc.Caculate();

            Console.WriteLine();
            Console.WriteLine(report);

            Console.WriteLine("Nhan phim bat ky de thoat");
            Console.ReadKey();
        }
    }
 }
