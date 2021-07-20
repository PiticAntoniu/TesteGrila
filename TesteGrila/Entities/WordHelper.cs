using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;

namespace TesteGrila
{
    internal class WordHelper
    {
        internal static List<TestItem> LoadItemsFromFile(string fileLocation)
        {
            List<TestItem> itemList = new List<TestItem>();

            Application wordApp = new Application();
            Document doc = wordApp.Documents.Open(fileLocation,ReadOnly:false);

//            Table 

            return itemList;
        }
    }
}