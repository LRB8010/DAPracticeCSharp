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
            //Console.WriteLine("Reverse a string!!");
            Console.WriteLine("Is it a palindrome?!");
            string input = Console.ReadLine();
            //ReverseAString(input);
            Palindrome(input);
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

        public static void Palindrome(string str)
        {
            string result = "";
            for (var i = 0; i < str.Length; i++)
            {
                result = str[i] + result;

            }
            if(str == result)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }

          

        }
    }

  
}

