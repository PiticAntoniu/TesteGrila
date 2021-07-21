using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteGrila
{
    class WordApp
    {
        static Application wordApp = null;
        static Document template = null;


        static public Application GetWordApp() {
            return wordApp ?? (wordApp = new Application());
        }

        static public Document GetTemplate()
        {
            return template ?? (template
                = GetWordApp().Documents.Open(Ct.DefaultLocation + Ct.DefaultTest, ReadOnly: false));
        }

    }
}
