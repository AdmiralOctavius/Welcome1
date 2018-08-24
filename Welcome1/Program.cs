using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Inline comments
/*
 * 
 * Another comment
 * */

namespace Welcome1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            string person = "Isabella";
            Console.WriteLine($"My name is: {person}");

            int number1;
            int number2;
            int sum;

            number1 = int.Parse(Console.ReadLine());
            number2 = int.Parse(Console.ReadLine());

            sum = number1 + number2;
            Console.WriteLine($"The sum of the two numbers is: {sum}");
        }
    }
}
