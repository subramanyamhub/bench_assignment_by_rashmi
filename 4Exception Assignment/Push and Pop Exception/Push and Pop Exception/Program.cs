using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Push_and_Pop_Exception
{
    public class Program
    {
        static void Main(string[] args)
        {
            StackException se = new StackException(10);
           

            try
            {
                 se.Pop();
            }
            catch
            {
                Console.WriteLine("Stack is Empty");
            }
            Console.ReadLine();
        }
    }
}
