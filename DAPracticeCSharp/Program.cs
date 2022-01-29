using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAPracticeCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a string");
            string input = Console.ReadLine();
            ReverseAString(input);
            Console.Read();
        }
        public static void ReverseAString(string str)
        {
            string result = "";
            for(var i = 0;i<str.Length;i++)
            {
                result = str[i] + result;  
                
            }
            Console.WriteLine(result);
        }
    }

  
}

