using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageMarks
{
    public class Class1
    {
        float a1, a2, a3, a4, a5;
        public void avg()
        {
            Console.WriteLine("Enter average marks for 5 students:");

            a1 = Single.Parse(Console.ReadLine());
            a2 = Single.Parse(Console.ReadLine());
            a3 = Single.Parse(Console.ReadLine());
            a4 = Single.Parse(Console.ReadLine());
            a5 = Single.Parse(Console.ReadLine());

            if (a1 > a2 && a1 > a3 && a1 > a4 && a1 > a5)
            {

                Console.WriteLine("\nThe highest of all average marks is: " + a1);
            }
            else if (a2 > a1 && a2 > a3 && a2 > a4 && a2 > a5)
            {
                Console.WriteLine("\nThe highest of all average marks is: " + a2);
            }
            else if (a3 > a1 && a3 > a2 && a3 > a4 && a3 > a5)
            {
                Console.WriteLine("\nThe highest of all average marks is: " + a3);
            }
            else if (a4 > a1 && a4 > a2 && a4 > a3 && a4 > a5)
            {
                Console.WriteLine("\nThe highest of all average marks is:" + a4);
            }
            else
            {
                Console.WriteLine("The highest marks is:" + a5);
            }
        }
    }
}
