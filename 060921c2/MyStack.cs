using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _060921c2
{
    class MyStack
    {
        static char[] p;
        static int index;
        public MyStack()
        {
            p = new char[1000];
            index = -1;
        }
        public static void Push(char c)
        {
            p[++index] = c;
        }
        public static char Pop()
        {
            char c = p[index];
            --index;
            return c;
        }
        public static char Peek()
        {
            char c = p[index];
            return c;
        }
        public static bool IsEmpty()
        {
            if (index==-1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static string PrintStack()
        {
            string s = "";
            for (int i = 0; i < index; i++)
            {
                s += p[index] + " ";
            }
            return s;
        }
    }
}
