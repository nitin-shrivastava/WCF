using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorService.Client.CalculatorServiceReference;

namespace CalculatorService.Client
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("1. Add");
            Console.WriteLine("2. Subtract");
            Console.WriteLine("3. Multiply");
            Console.WriteLine("4. Divide");
            Console.WriteLine("Enter Operation");
            var op = Console.ReadLine();
            int num1 = 0;
            int num2 = 0;

            switch(op)
            {
                case "1":
                    GetInput(out num1, out num2);
                    Console.WriteLine($"Result {new CalculatorServiceClient().Add(num1, num2)}");
                    break;
                case "2":
                    GetInput(out num1, out num2);
                    Console.WriteLine($"Result {new CalculatorServiceClient().Subtract(num1, num2)}");
                    break;
                case "3":
                    GetInput(out num1, out num2);
                    Console.WriteLine($"Result {new CalculatorServiceClient().Multiply(num1, num2)}");
                    break;
                case "4":
                    GetInput(out num1, out num2);
                    Console.WriteLine($"Result {new CalculatorServiceClient().Divide(num1, num2)}");
                    break;

            }
            Console.ReadLine();
            
        }
        private static void GetInput(out int numF, out int numS)
        {
            Console.WriteLine("Please enter first value:");
            numF = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter second value:");
            numS = int.Parse(Console.ReadLine());
        }
    }
}
