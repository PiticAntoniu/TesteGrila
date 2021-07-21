using Microsoft.Office.Interop.Word;
using System;
using System.IO;
using System.Collections.Generic;

namespace TesteGrila
{
    internal class WordHelper
    {
        internal static List<TestItem> LoadItemsFromFile(string fileLocation)
        {
            List<TestItem> itemList = new List<TestItem>();
 
            try
            {
                
                foreach (Table table in WordApp.GetTemplate().Tables)
                {
                    itemList.Add(GetItemFromTable(table));
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return itemList;
        }

        internal static void Save(List<TestItem> itemList, string defaultGeneratedTest)
        {
            Document doc;
            if (File.Exists(Ct.DefaultLocation + Ct.DefaultGeneratedTest))
                File.Delete(Ct.DefaultLocation + Ct.DefaultGeneratedTest);
            File.Copy(Ct.DefaultLocation+Ct.DefaultTest, 
                                Ct.DefaultLocation + Ct.DefaultGeneratedTest);

                doc = WordApp.GetWordApp().Documents.Open(Ct.DefaultLocation + defaultGeneratedTest, ReadOnly: false);
                int index = 1;
                foreach (var item in itemList)
                {
                    Table table = doc.Tables[index++];

                    table.Cell(1, 1).Range.Text = item.Question;

                    int column = 1;
                    foreach (var choice in item.Choices)
                    {
                       // table.Cell(2, column).Range.Delete();
                        choice.Body.Copy();
                        table.Cell(2, column++).Range.Paste();
                    }
                }

                doc.Close(true);


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