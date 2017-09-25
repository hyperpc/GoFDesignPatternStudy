namespace ch0502_Command.SimpleCalculator
{
    class CalculatorCommand : Command
    {
        private char @operator;
        int operand;
        Calculator calculator;
        public CalculatorCommand(Calculator calculator, char @operator, int operand)
        {
            this.calculator = calculator;
            this.operand = operand;
            this.@operator = @operator;
        }
        public char Operator
        {
            set
            {
                @operator = value;
            }
        }
        public int Operand
        {
            set
            {
                operand = value;
            }
        }
        private char Undo(char @operator)
        {
            char undo = ' ';
            switch (@operator)
            {
                case '+':
                    undo = '-';
                    break;
                case '-':
                    undo = '+';
                    break;
                case '*':
                    undo = '/';
                    break;
                case '/':
                    undo = '*';
                    break;
            }
            return undo;
        }
        public override void Execute()
        {
            calculator.Operation(@operator, operand);
        }

        public override void UnExecute()
        {
            calculator.Operation(Undo(@operator), operand);
        }
    }
}
