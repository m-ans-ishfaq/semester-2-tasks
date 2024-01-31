using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfAssessment.Two
{
    internal class Calculator
    {
        public double firstNumber;
        public double secondNumber;

        public Calculator(double value1, double value2)
        {
            this.firstNumber = value1;
            this.secondNumber = value2;
        }

        public double Add()
        {
            return firstNumber + secondNumber;
        }
        public double Subtract()
        {
            return firstNumber - secondNumber;
        }
        public double Multiply()
        {
            return firstNumber * secondNumber;
        }
        public double Divide()
        {
            return firstNumber / secondNumber;
        }
    }
}
