using System;

namespace ch0502_Command.SimpleCalculator
{
    class Calculator
    {
        private int total = 0;
        public void Operation(char @operator, int operand)
        {
            switch (@operator)
            {
                case '+':
                    total += operand;
                    break;
                case '-':
                    total -= operand;
                    break;
                case '*':
                    total *= operand;
                    break;
                case '/':
                    total /= operand;
                    break;
            }
            Console.WriteLine("Total = {0} (following {1}{2})", total, @operator, operand);
        }
    }
}
