using System;
using System.Collections.Generic;
using System.IO;

namespace DataTypesProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 4;
            double d = 4.0;
            string s = "HackerRank ";
            int myInt = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(myInt + i);
            double myDouble = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine((myDouble + d).ToString("F1")); 
            string myString = Console.ReadLine();
            Console.WriteLine(s + myString);
            Console.ReadKey();



        }
    }
}
