using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swapping
{
    public class Class1
    {
        int n1, n2, temp;
        public void Swapping()
        {
            Console.WriteLine("Enter the first number and then press enter:");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("\nEnter the second number and then press enter:");
            n2 = int.Parse(Console.ReadLine());

            temp = n1;
            n1 = n2;
            n2 = temp;

            Console.WriteLine("\nAfter swapping---");

            Console.WriteLine("\nNow the First number is :" + n1);
            Console.WriteLine("\nNow the Second number is:" + n2);
        }
    }
}
