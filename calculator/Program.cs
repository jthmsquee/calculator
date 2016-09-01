using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter one of the following commands:");
                Console.WriteLine("add");
                Console.WriteLine("subtract");
                Console.WriteLine("multiply");
                Console.WriteLine("divide");
                Console.WriteLine("quit");
                Console.WriteLine();
                string inputText = Console.ReadLine();
                Console.WriteLine();

                if (inputText == "add")
                {
                    Console.WriteLine("Enter A Number");
                    string a = Console.ReadLine();
                    Console.WriteLine("Enter Another Number");
                    string b = Console.ReadLine();
                    int firstNumber = Convert.ToInt32(a);
                    int secondNumber = Convert.ToInt32(b);
                    Console.WriteLine(add(secondNumber, firstNumber));

                }
                else if (inputText == "subtract")
                {
                    Console.WriteLine("Enter A Number");
                    string a = Console.ReadLine();
                    Console.WriteLine("Enter Another Number");
                    string b = Console.ReadLine();
                    int firstNumber = Convert.ToInt32(a);
                    int secondNumber = Convert.ToInt32(b);
                    Console.WriteLine(subtract(firstNumber, secondNumber));
                }
                else if (inputText == "Multiply")
                {
                    Console.WriteLine("Enter A Number");
                    string a = Console.ReadLine();
                    Console.WriteLine("Enter Another Number");
                    string b = Console.ReadLine();
                    int firstNumber = Convert.ToInt32(a);
                    int secondNumber = Convert.ToInt32(b);
                    Console.WriteLine(multiplication(firstNumber, secondNumber));
                }
                else if (inputText == "divide")
                {
                    Console.WriteLine("Enter A Number");
                    string a = Console.ReadLine();
                    Console.WriteLine("Enter Another Number");
                    string b = Console.ReadLine();
                    int firstNumber = Convert.ToInt32(a);
                    int secondNumber = Convert.ToInt32(b);
                    Console.WriteLine(divide(firstNumber, secondNumber));
                }
                else if (inputText == "quit")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("invalid command");
                }   
            }
        }

        private static int add(int triangle, int circle)
        {
            return triangle + circle;
        }

        private static int subtract(int a, int b)
        {
            return a - b;
        }
        private static int multiplication(int a, int b)
        {
            return a * b;
        }

        private static double divide(double a, double b)
        {
            return a / b;
        }
    }
}

