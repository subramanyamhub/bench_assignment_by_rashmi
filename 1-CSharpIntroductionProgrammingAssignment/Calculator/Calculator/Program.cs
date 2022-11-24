using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            double num1 = 0;
            double num2 = 0;

            Console.WriteLine("Type your first number and then press enter:");
            num1=Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Type your second number and then press enter:");
            num2 = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("\nPlease choose the function to perform:- ");
            Console.WriteLine("\npress 1 and then press enter for------Addition");
            Console.WriteLine("press 2 and then press enter for------subtraction");
            Console.WriteLine("press 3 and then press enter for------Multiplication");
            Console.WriteLine("press 4 and then press enter for------Division");
            Console.WriteLine("\nEnter your option and then press enter.");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine($"Your result:{num1}+{num2}=" +(num1+num2));
                    break;

                case "2":
                    Console.WriteLine($"Your result:{num1}-{num2}=" + (num1 - num2));
                    break;

                case "3":
                    Console.WriteLine($"Your result:{num1}*{num2}=" + (num1 * num2));
                    break;

                case "4":
                    while (num2 == 0)
                    {
                        Console.WriteLine("\nEnter non-zero number");
                        num2=Convert.ToDouble(Console.ReadLine());
                    }
                    Console.WriteLine($"\nYour result:{num1}/{num2}=" + (num1 / num2));
                    break;
            }
            Console.ReadLine();
        }
        
    }
}
