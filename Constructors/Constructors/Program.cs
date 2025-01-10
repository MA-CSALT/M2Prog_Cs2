namespace Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Run();
        }

        internal void Run()
        {
            QuizVraag quizvraag = new QuizVraag("hier komt de vraag.", "hier komt het antwoord.");
            Quiz quiz = new Quiz(10);
        }
    }
}
