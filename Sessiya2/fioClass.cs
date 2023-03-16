using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sessiya2
{
    class fioClass
    {
        public static string Surname, Name, LastName;
        public static void space_FIO(string text)
        {
            string copyText = null;
            int countSpace = 0;
            char space = (char)32;
            for (int i = 0; i <= text.Length; i++)
            {
                if ((i == text.Length) && (countSpace == 2))
                {
                    LastName = copyText;
                    break;
                }
                else if ((text[i] == space) && (countSpace == 0))
                {
                    Surname = copyText;
                    countSpace += 1; i++;
                    copyText = "";
                }
                else if ((text[i] == space) && (countSpace == 1))
                {
                    Name = copyText;
                    countSpace += 1; i++;
                    copyText = "";
                }
                copyText += text[i];

            }
        }

        public static string series, number;
        public static void space_Pass(string text)
        {
            string copyText = null;
            int countspace = 0;
            char space = (char)32;

            for (int i = 0; i <= text.Length; i++)
            {
                if (i == text.Length) { number = copyText; break; }
                if (text[i] == space)
                {
                    series = copyText; countspace++;
                    copyText = ""; i++;
                }
                copyText += text[i];

            }
        }
    }
}
