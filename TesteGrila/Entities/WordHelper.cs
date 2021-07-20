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


                foreach (Table table in doc.Tables)
                {
                    itemList.Add(GetItemFromTable(table));
                }



                doc.Close(false);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            wordApp.Quit();
            return itemList;
        }

        private static TestItem GetItemFromTable(Table table)
        {
            TestItem testItem = new TestItem();
            testItem.Choices = new List<Choice>();

            testItem.Question = table.Cell(1, 1).Range.Paragraphs[1].Range.Text;

            for (int i = 1; i <= table.Columns.Count; i++)
            {
                testItem.Choices.Add(new Choice
                {
                    Body = table.Cell(2, i).Range,
                    IsCorrect = true
                });
            }

            return testItem;
        }
    }
}