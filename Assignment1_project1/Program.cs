using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Calculator
    {
        public static void Main(string[] args)
        {
            long a, b;
            string op = "";
            while (true)
            {
                Console.WriteLine("请输入要计算的两个数:");
                a = int.Parse(Console.ReadLine());
                b = int.Parse(Console.ReadLine());
                Console.WriteLine("请输入要进行计算的运算符:");
                op = Console.ReadLine();
                switch (op)
                {
                    case "+":
                        Add(a, b);
                        break;
                    case "-":
                        Minus(a, b);
                        break;
                    case "*":
                        Multiply(a, b);
                        break;
                    case "/":
                        Divide(a, b);
                        break;
                    default:
                        Console.WriteLine("NULL");
                        break;
                }
            }
            Console.ReadLine();
        }
        public static void Add(long a, long b)
        {
            Console.WriteLine("{0}+{1} = {2}", a, b, a + b);
        }
        public static void Minus(long a, long b)
        {
            Console.WriteLine("{0}-{1} = {2}", a, b, a - b);
        }
        public static void Multiply(long a, long b)
        {
            Console.WriteLine("{0}*{1} = {2}", a, b, a * b);
        }
        public static void Divide(long a, long b)
        {
            Console.WriteLine("{0}/{1} = {2}", a, b, a / b);
        }
    }
}