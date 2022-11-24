using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList EmployeeList01 = new ArrayList();
            EmployeeList01.Add("1");
            EmployeeList01.Add("Raviendra");
            EmployeeList01.Add("Vijayawada");
            EmployeeList01.Add("89854753242");

            ArrayList EmployeeList02 = new ArrayList();
            EmployeeList02.Add("2");
            EmployeeList02.Add("Balasai");
            EmployeeList02.Add("Hyderabad");
            EmployeeList02.Add("6303360881");

            Console.WriteLine(EmployeeList01[0]);
            Console.WriteLine(EmployeeList01[1]);
            Console.WriteLine(EmployeeList01[2]);

            Console.WriteLine(EmployeeList02[0]);
            Console.WriteLine(EmployeeList02[1]);
            Console.WriteLine(EmployeeList02[2]);


            Console.ReadLine();
        }
    }
}
