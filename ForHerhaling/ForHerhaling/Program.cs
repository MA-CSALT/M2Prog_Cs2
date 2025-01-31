namespace ForHerhaling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.run();
        }
        internal void run()
        {
            double[] prijzen = new double[] { 0.99, 5.60, 10.11, 4.50 };
            string[] artikelen = {"snoepje", "luxe broodje", "lunch menu", "omelet" };
            Formulier[] formulieren = new Formulier[2];

            formulieren[0] = new Formulier()
            {
                Feedback = "prijzig maar lekker"
                , Sterren = 5
            };

            formulieren[1] = new Formulier()
            {
                Feedback = "niet het geld waard",
                Sterren = 1
            };

            for (int i = 0; i < prijzen.Length; i++)
            {
                Console.WriteLine(prijzen[i]);
                Console.WriteLine(artikelen[i]);
            }

            foreach (Formulier formulier in formulieren)
            {
                Console.WriteLine(formulier.Feedback);
                Console.WriteLine(formulier.Sterren);
                
            }
        }
    }
}
