namespace Command_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
  
                var editor = new TextEditor();
                var commandManager = new CommandManager();


                var insertCommand1 = new InsertTextCommand(editor, "shobla ");
                var insertCommand2 = new InsertTextCommand(editor, "e_la!");

                commandManager.ExecuteCommand(insertCommand1);
                Console.WriteLine($"выводим текст  {editor.GetT()}");

                commandManager.ExecuteCommand(insertCommand2);
                Console.WriteLine($"выводим текст  {editor.GetT()}");

               
                var deleteCommand = new DeleteTextCommand(editor, 6);
                commandManager.ExecuteCommand(deleteCommand);
                Console.WriteLine($"выводим текст после удаления {editor.GetT()}");

              
                commandManager.UndoLastCommand();
                Console.WriteLine($"выводим текст после удаления {editor.GetT()}");

                commandManager.UndoLastCommand();
                Console.WriteLine($"выводим текст после отмены {editor.GetT()}");
               
            }
        }
    }
