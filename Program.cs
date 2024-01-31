using System;
using System.Transactions;
using Challenges.One;
using SelfAssessment.Two;

namespace OOPS
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Calculator c = new Calculator(2, 3);
            c.Add();
        }
    }
}