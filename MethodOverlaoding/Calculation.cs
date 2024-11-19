using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverlaoding
{
    internal class Calculation
    {
        public int Add(int a, int b) 
        { 
            return a + b; 
        }

        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }

        public double Add(int a, double b)
        {
            return a + b;
        }

        public double Add(double a, int b)
        {
            return a + b;
        }

        // Subtraction

        public int Sub(int a, int b)
        {
            return a - b;
        }

        public double Sub(double a, double b)
        {
            return a - b;
        }

        public double Sub(int a, double b)
        {
            return a - b;
        }

        public double Sub(double a, int b)
        {
            return a - b;
        }


        // Multiplication

        public int Mul(int a, int b)
        {
            return a * b;
        }

        public double Mul(double a, double b)
        {
            return a * b;
        }

        public double Mul(int a, double b)
        {
            return a * b;
        }

        public double Mul(double a, int b)
        {
            return a * b;
        }

        // Division

        public int Div(int a, int b)
        {
            return a / b;
        }

        public double Div(double a, double b)
        {
            return a / b;
        }

        public double Div(int a, double b)
        {
            return a / b;
        }

        public double Div(double a, int b)
        {
            return a / b;
        }

    }
}
