namespace functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program(); //program, Program
            program.Run(); //Run, void
        }
        internal void Run() {
            Console.WriteLine("Dit is nu de start van mijn programma");
        }
    }
}
