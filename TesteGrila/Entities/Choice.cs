namespace TesteGrila
{
    internal class Choice
    {
        object body;
        bool isCorrect;

        public object Body { get => body; set => body = value; }
        public bool IsCorrect { get => isCorrect; set => isCorrect = value; }
    }
}