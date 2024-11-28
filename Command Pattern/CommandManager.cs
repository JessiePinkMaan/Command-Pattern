using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_Pattern
{
    public class CommandManager
    {
        private readonly Stack<ICommand> commandHistory = new();//храним команды

        public void ExecuteCommand(ICommand command)
        {
            command.Execute();
            commandHistory.Push(command);
        }

        public void UndoLastCommand()//вызывем метод undo у последней команды 
        {
            if (commandHistory.Count > 0)
            {
                var lastCommand = commandHistory.Pop();
                lastCommand.Undo();
            }
            else//если нечего вызвать (((
            {
                Console.WriteLine("___________-----_____---___--");
            }
        }
    }
}
