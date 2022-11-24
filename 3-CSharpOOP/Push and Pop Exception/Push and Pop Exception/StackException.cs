using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Push_and_Pop_Exception
{
    public class StackException
    { 

        int[] stack;
        int sp;

        public StackException(int size)
        {
            stack = new int[size];
            sp = 0;

        }
        public bool Push(int item)
        {
            if(sp < stack.Length)
            {
                stack[sp] = item;
                sp++;
                return true;
            }
            else
            {
                throw new Exception("Stack is Full!!");
            }
        }

        public int Pop()
        {
            if (sp > 0)
            {
                sp--;
                return stack[sp];
            }
            else
            {
                throw new Exception("Stack is Empty!!");
            }
        }
    }
}
