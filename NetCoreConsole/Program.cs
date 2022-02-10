using System;

namespace NetCoreConsole
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static int AddNumbers(int a, int b) => a + b;

        public static int SubstractNumbers(int a, int b) => a - b;

        public static int MultiplyNumbers(int a, int b) => a * b;

        public static int DivideNumbers(int a, int b) => a / b;
    }
}