using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1
{
    class Program
    {
        enum vars
        {
            min = 1,
            max = 30,
            avg = 17
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var i = 4.3;
            var j = 4;
            var s = "string";
            var c = '1';
            const int constant = 10;
            Console.WriteLine($"{i.GetType()}\t{j.GetType()}\t{s.GetType()}\t{c.GetType()}\t{constant.GetType()}");

            Console.Write($"min = {(double)vars.min}\nmax = {(vars.max).ToString() == "max"}\navg = {(int)vars.avg}\n");
            // Строковая интерполяция более эффективна, чем использование оператора +.

            double x = Math.E, cos = Math.Cos(1.1), proc = 0.98765;
            Console.WriteLine($"exp = " + x + "\ncos(1.1) = {0:num 0.00}", cos);
            Console.WriteLine($"% = {proc,5:p}");

            double zero = 0.0;
            Console.Write("Введите число = ");
            Console.WriteLine("Введеное число + 100 = {0}", double.Parse(Console.ReadLine()) + 100);
            Console.Write("NaN = " + zero / zero);

            Console.ReadKey();
        }
    }
}