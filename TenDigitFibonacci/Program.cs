using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TenDigitFibonacci
{
    class Program
    {
        //INSTRUCTIONS --
        /*Please complete for Coding Challenge 3:        The Fibonacci sequence is defined by the recurrence relation:        Fn = Fn−1 + Fn−2, where F1 = 1, F2 = 1, F3 = 2, .... and F12 = 144. F12 is the first term to contain three digits.         What is the index of the first term in the Fibonacci sequence to contain 10 digits?
        */

        static void Main(string[] args)
        {
            int a = 1;
            int x = 0;
            int count = 1;

            for (int i = 1; i <= 1200000000; i = x + a)
            {

                if (i >= 1000000000)
                {
                    //Console.WriteLine(i);
                    x = a;
                    a = i;
                    Console.WriteLine("The first 10 digit number in the sequence is:");
                    Console.WriteLine(i);
                    Console.WriteLine();
                    Console.Write("The index is F");
                    Console.WriteLine(count);
                }
                else
                {
                    //Console.WriteLine(i);
                    x = a;
                    a = i;
                    count++;
                }
            } 



        }
    }
}
