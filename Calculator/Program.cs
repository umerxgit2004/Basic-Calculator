using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args) {

            int num1;
            int num2;
            string ans;

            int result = 0;

            Console.WriteLine("Hello, Welcome to the calulator program");
            Console.WriteLine("Please enter your first Number:");

            num1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(num1);

            Console.WriteLine("Please enter your Second Number");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What type of operation would you like to do?");
            Console.WriteLine("Please enter a for addition, s for subtraction, m for multiplication or d for division.");
            ans = Console.ReadLine();

            if (ans == "a")
            {
                result = num1 + num2;
            }
            else if (ans == "s")
            {
                result = num1 - num2;
            }
            else if (ans == "m")
            {
                result = num1 * num2;
            }
            else if (num2 != 0 && ans == "d")
            {
                result = num1 / num2;
            }
            else
            {
                Console.WriteLine("KINDLY ENTER THE CORRECT OPERATOR");
            }
            Console.WriteLine("The result is "+ result);
            Console.WriteLine("Thank you for using the calulator program");

            Console.ReadKey();
        }
    }
    }
