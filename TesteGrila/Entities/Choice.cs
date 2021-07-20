using Microsoft.Office.Interop.Word;

namespace TesteGrila
{
    internal class Choice
    {
        Range body;
        bool isCorrect;

        public Range Body { get => body; set => body = value; }
        public bool IsCorrect { get => isCorrect; set => isCorrect = value; }
    }
}