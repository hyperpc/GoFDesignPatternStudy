using System;
using System.Collections;

namespace ch0502_Command.SimpleCalculator
{
    class User
    {
        private Calculator calculator = new Calculator();
        private ArrayList commands = new ArrayList();
        private int current = 0;
        public void Redo(int levels)
        {
            Console.WriteLine("----- Redo {0} levels ", levels);
            for (int i = 0; i < commands.Count; i++)
            {
                if (current < commands.Count - 1)
                    ((Command)commands[current++]).Execute();
            }
        }

        public void Undo(int levels)
        {
            Console.WriteLine("----- Undo {0} levels ", levels);
            for (int i = 0; i < commands.Count; i++)
            {
                if (current >0)
                    ((Command)commands[--current]).UnExecute();
            }
        }
        public void Computer(char @operator, int operand)
        {
            Command command = new CalculatorCommand(calculator, @operator, operand);
            command.Execute();
            commands.Add(command);
            current++;
        }
    }
}
