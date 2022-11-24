using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_of_Integers_Array
{
    public class Class1
    {
        int[] a = new int[50];
        int i, n, sum = 0;

        public void Sum()
        {
            Console.WriteLine("\nEnter the number of elements to perfrom the Sum function:");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nInput {0} elements in the array :\n", n);
            for (i = 0; i < n; i++)
            {
                Console.WriteLine("element {0} : ", i);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (i = 0; i < n; i++)
            {
                sum += a[i];
            }

            Console.WriteLine("\nSum of all the elements stored in the array is:{0}\n\n", +sum);
        }


    }
}

