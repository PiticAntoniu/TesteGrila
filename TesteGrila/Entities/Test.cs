using System;
using System.Collections.Generic;
using System.Linq;

namespace TesteGrila
{
    internal class Test
    {
        List<TestItem> itemList = new List<TestItem>();
        internal List<TestItem> ItemList { get => itemList; set => itemList = value; }

        public Test(string defaultTest)
        {
            itemList = WordHelper.LoadItemsFromFile(defaultTest);
        }

        internal void Shuffle()
        {
            Random r = new Random();
            itemList = itemList.OrderBy(x => r.Next()).ToList();

            foreach (var item in itemList)
            {
                item.Choices = item.Choices.OrderBy(x => r.Next()).ToList();
            }
        }

        internal void Save(string defaultGeneratedTest)
        {
            WordHelper.Save(itemList, defaultGeneratedTest);
        }
    }
}