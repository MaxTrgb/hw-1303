using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0403wfCLass
{
    public static class CalculatorModel
    {
        public static double numOne { get; set; }
        public static double numTwo { get; set; }

        public static double add(double numOne, double numTwo) { 
            return numOne + numTwo;
        }

        public static double substract(double numOne, double numTwo)
        {
            return numOne - numTwo;
        }

        public static double multiply(double numOne, double numTwo)
        {
            return numOne * numTwo;
        }

        public static double divide(double numOne, double numTwo)
        {
            return numOne / numTwo;
        }
    }
}
