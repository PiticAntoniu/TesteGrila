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
            Document doc;
            Application wordApp = new Application();
            try
            {
                doc = wordApp.Documents.Open(Ct.DefaultLocation + fileLocation, ReadOnly: false);

                Table t = doc.Tables[1];

                Console.WriteLine(t.Cell(2, 3).Range.Text);

                doc.Close(false);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            wordApp.Quit();
            return itemList;
        }
    }
}