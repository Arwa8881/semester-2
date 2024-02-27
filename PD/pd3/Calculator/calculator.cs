using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    internal class calculator
    {
        public class Calculator
        {
            public int number1;
            public int number2;

            public Calculator(int num1 = 10, int num2 = 10)
            {
                number1 = num1;
                number2 = num2;
            }

            public int Add()
            {
                return number1 + number2;
            }

            public int Subtract()
            {
                return number1 - number2;
            }

            public int Multiply()
            {
                return number1 * number2;
            }

            public double Divide()
            {
                if (number2 != 0)
                {
                    return (double)number1 / number2;
                }
                else
                {
                    Console.WriteLine("Error: Cannot divide by zero.");
                    return 0;
                }
            }

            public int Modulo()
            {
                return number1 % number2;
            }
            public double Sqrt(int num)
            {
                return Math.Sqrt(num);
            }

            public double Exp(int num)
            {
                return Math.Exp(num);
            }

            public double Log(int num)
            {
                return Math.Log(num);
            }

            public double Sin(int angle)
            {
                double radians = angle * Math.PI / 180;
                return Math.Sin(radians);
            }

            public double Cos(int angle)
            {
                double radians = angle * Math.PI / 180;
                return Math.Cos(radians);
            }

            public double Tan(int angle)
            {
                double radians = angle * Math.PI / 180;
                return Math.Tan(radians);
            }
        }

    }

    }
    

    

