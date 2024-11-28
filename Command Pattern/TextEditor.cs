using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_Pattern
{
    public class TextEditor
    {
        private string text = "";

        public void PlusText(string newText)
        {
            text += newText;
        }


        public void DelText(int length)
        {
            if (length > text.Length) // Убедимся, что длина не превышает доступный текст
                length = text.Length;
            text = text.Substring(0, text.Length - length);
        }


        public string GetT()// получаем
        {
            return text;
        }
    }
}
