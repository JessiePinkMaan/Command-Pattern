using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_Pattern
{
    public class DeleteTextCommand : ICommand
    {
        private readonly TextEditor editor;
        private readonly int length; //Число символов которые нужно удалить из текста
        private string deletedText;// сохраняем символы чтобы востановить 

        public DeleteTextCommand(TextEditor Editor, int Length)
        {
            editor = Editor;
            length = Length;
        }

        public void Execute()
        {
           
            var currentText = editor.GetT();//получаем тьекст
            deletedText = currentText.Substring(currentText.Length - length);// извлекаем строку с нужной длиной и сохраняем в переменную 
            editor.DelText(length);
        }

        public void Undo()
        {
            editor.PlusText(deletedText);
        }
    }
}
