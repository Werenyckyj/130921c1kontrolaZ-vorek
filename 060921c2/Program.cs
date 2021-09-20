using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _060921c2
{
    class Program
    {
        static void Main(string[] args)
        {
            string zavorky = "{}[]()";
            string notok = "3+2{3+[4(2+])}+2"; string ok = "3+2{3+[4(2)]}+2";
            Console.WriteLine(notok);
            MyStack x = new MyStack();
            for (int i = 0; i < notok.Length; i++)
            {
               char c = notok[i];
                if (c==zavorky[0]|| c == zavorky[2]|| c == zavorky[4])
                {
                    x.Push(c);
                }
                if (c == zavorky[1] || c == zavorky[3] || c == zavorky[5])
                {
                    char ch = x.Peek();
                    if (ch==c)
                    {
                        x.Pop();
                    }
                    else
                    {
                        Console.WriteLine("Chyba!!!");
                    }
                }
            }
            Console.WriteLine(ok);

            Console.ReadLine();
        }
    }
}
