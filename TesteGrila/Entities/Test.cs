using System;
using System.Collections.Generic;

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
           // throw new NotImplementedException();
        }

        internal void Save(string defaultGeneratedTest)
        {
            WordHelper.Save(itemList, defaultGeneratedTest);
        }
    }
}