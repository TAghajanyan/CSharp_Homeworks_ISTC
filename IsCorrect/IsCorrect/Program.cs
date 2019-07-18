using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsCorrect
{
    class Program
    {
        static char[] stack = new char[100];
        static int index = 0; 
        
        static void Push(char ch)
        {
            stack[index] = ch;
            index++;
        }

        static char Pop()
        {
            if (index == 0)
            {
                return '0';
            }
            index--;
            return stack[index];
        }

        static bool IsCorrect(string str)
        {
            char[] symbol = { '{', '(', '[', '}', ')', ']' };
            int len = str.Length;
            int index1 = 0;

            // dsadsd{sdasd}sad(sdasd[sadd]adasd}a{sd)

            for (int i = 0; i < len; i++)
            {
                index1 = 0;
                if (str[i] == symbol[index1] || str[i] == symbol[++index1] || str[i] == symbol[++index1])
                {
                    Push(str[i]);
                }
                if (str[i] == symbol[++index1] || str[i] == symbol[++index1] || str[i] == symbol[++index1])
                {
                    char c = Pop();
                    if (c != symbol[index1 - 3] || c == '0')
                    {
                        return false;
                    }
                }
            }
            return true;

        }

        static void Main(string[] args)
        {
            Console.WriteLine(IsCorrect("aas{asaa[aaa(ass)sass]sss}ass")); // true
            Console.WriteLine(IsCorrect("aa{sa[asas(sas]as)as}asa")); // false
            Console.WriteLine(IsCorrect("{{[[(())]]}}")); // true
        }
    }
}

