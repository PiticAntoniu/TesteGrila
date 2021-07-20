using System.Collections.Generic;

namespace TesteGrila
{
    internal class TestItem
    {
        string Question;
        List<Choice> choices = new List<Choice>();
        int value;

        public string Question1 { get => Question; set => Question = value; }
        public int Value { get => value; set => this.value = value; }
        internal List<Choice> Choices { get => choices; set => choices = value; }
    }
}