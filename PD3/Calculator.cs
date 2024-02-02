using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS.PD3
{
    internal class Calculator
    {
        public double n1, n2;

        public Calculator(double n1, double n2)
        {
            this.n1 = n1;
            this.n2 = n2;
        }
 
        public double Add()
        {
            return n1 + n2;
        }

        public double Subtract() 
        { 
            return n1 - n2;
        }

        public double Multiply()
        {
            return n1 * n2;
        }

        public double Divide()
        {
            if (n2 == 0)
                return 0;
            return n1 / n2;
        }

        public int Modulo()
        {
            return Convert.ToInt32(n1) % Convert.ToInt32(n2);
        }

        public int SquareRoot(int number)
        {
            return (number * number);
        }

        public int Exponential(int number)
        {
            double n = Convert.ToDouble(number);
            return Convert.ToInt32(Math.Pow(n, n));
        }

        public int Logarithm(int number)
        {
            double n = Convert.ToDouble(number);
            return Convert.ToInt32(Math.Log(n));
        }

        private double ToRadian(int degree)
        {
            return Convert.ToInt32(degree * 0.01745329251);
        }

        public int Sine(int degree)
        {
            double radian = ToRadian(degree);
            return Convert.ToInt32(Math.Sin(radian));
        }

        public int Cos(int degree)
        {
            double radian = ToRadian(degree);
            return Convert.ToInt32(Math.Cos(radian));
        }

        public int Tan(int degree)
        {
            double radian = ToRadian(degree);
            return Convert.ToInt32(Math.Tan(radian));
        }

    }
}
