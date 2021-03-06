using System;
using System.Collections.Generic;
//using System.Threading.Tasks;

namespace TestDoxy
{
    /*!
     \brief Реализует решение задачи скобочной последовательности 
     
     */
    class Program
    {
        /*! 
         Функция решения задачи
         -------------------------------------------------------------
         Решает задачу: https://codeforces.com/problemset/problem/26/B

       */
        //TASK 
        static void Main(string[] args)
        {

            string s = Console.ReadLine();
            var stack = new TestStack<char>();
            int c = 0, len=0;
            for(int i = 0; i < s.Length; ++i)
            {
                stack.Add(s[i]);
                if (stack.Push() == '(')
                {
                    c++;
                }
                if (stack.Push() == ')')
                {
                    if (c > 0)
                    {
                        c--;
                        len++;
                    }
                }
            }
            Console.WriteLine(len * 2);
            Console.ReadLine();
        }
    }
}
