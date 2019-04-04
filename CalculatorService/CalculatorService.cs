using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CalculatorService
{
    public class CalculatorService : ICalculatorService
    {
        public int Add(int a, int b) => a + b;

        public int Divide(int a, int b) => a / b;

        public int Multiply(int a, int b) => a * b;

        public int Subtract(int a, int b) => a - b;
    }
}
