using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_2__C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter x: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter:\nA, a\nB, b\nC, c\n");
            Console.Write("Enter variant: ");
            string variant = Console.ReadLine();

            double z;
            switch (variant)
            {
                case "A":
                case "a":
                    if(Math.Tan(x) < 0)
                    {
                        Console.WriteLine("Error: tangent is negative, square root cannot be calculated.");
                    }
                    else
                    {
                        z = Math.Sqrt(Math.Tan(x));
                        Console.WriteLine($"Result: {z}");
                    }
                    break;
                case "B":
                case "b":
                    if (Math.Tan(x) == 0)
                    {
                        Console.WriteLine("Error: tangent is zero, division by zero is impossible.");
                    }
                    else
                    {
                        z = 1 / Math.Tan(x);
                        Console.WriteLine($"Result: {z}");
                    }
                    break;
                case "C":
                case "c":
                    if (Math.Tan(x) < 0)
                    {
                        Console.WriteLine("Error: Tangent must be positive to calculate natural logarithm.");
                    }
                    else
                    {
                        z = Math.Log(Math.Tan(x));
                        Console.WriteLine($"Result: {z}");
                    }
                    break;
            }
        }
    }
}