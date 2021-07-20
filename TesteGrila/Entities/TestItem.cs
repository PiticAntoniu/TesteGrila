using System.Collections.Generic;

namespace TesteGrila
{
    internal class TestItem
    {
        string question;
        List<Choice> choices = new List<Choice>();
        int value;

        public string Question { get => question; set => question = value; }
        public int Value { get => value; set => this.value = value; }
        internal List<Choice> Choices { get => choices; set => choices = value; }
    }
}