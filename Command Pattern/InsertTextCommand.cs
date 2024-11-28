using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_Pattern
{
    public class InsertTextCommand : ICommand
    {
        private readonly TextEditor editor;//ссылка на обьект TextEditor   
        private readonly string _text;

        public InsertTextCommand(TextEditor Editor, string text)
        {
            editor = Editor;
            _text = text;
        }

        public void Execute()// вызываем метод PlusTextt у TextEditor чтобы добавить строку _text 
        {
            editor.PlusText(_text);
        }

        public void Undo()// отмена команды через вызов DelText
        {
            editor.DelText(_text.Length);
        }
    }
}
