using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator4NUnit
{
    public class Calculator
    {
        public int AddTwoNumbers(int number1, int number2)
        {
            return number1 + number2;
        }

        public int SubstractTwoNumbers(int number1, int number2)
        {
            return number1 - number2;
        }

        public object MultiplyTwoNumbers(int number1, int number2)
        {
            return number1 * number2;
        }

        public object DivideTwoNumbers(int number1, int number2)
        {
            return (number1 / number2);
        }
    }
}
