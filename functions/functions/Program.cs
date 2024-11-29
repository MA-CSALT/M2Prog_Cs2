namespace functions
{
    internal class Program
    {
        string[] vragen = new string[]
        {
            "What sound does a cat make?",
            "Are you indecisive?",
            "Which spooky 2001 GameCube game starring Mario’s brother got a reboot for Nintendo Switch in 2019?",
            "In May 2022, the government of what European nation banned its employees from using American gaming terms such as \"e-sports,\" instead using their domestic language counterparts like \"jeu video de competition?\"",
            "Regarded as one of the greatest video games of all time, what 1981 arcade game features the titular amphibian trying to cross a road without getting squashed by cars, and a river without getting eaten by predators?",
            "What is thought to be the first video game, created in 1958 and becoming popular in the 1970s?"
        };

        internal string GetVraag(int vraagIndex)
        {
            return vragen[vraagIndex];
    
        }

        internal string GetRandomVraag()
        {
            Random rnd = new Random();
            int random = rnd.Next(vragen.Length);
            return GetVraag(random);
        }
        static void Main(string[] args)
        {
            Program program = new Program(); //program, Program
            program.Run(); //Run, void
        }
        internal void Run()
        {
            Console.WriteLine("Dit is nu de start van mijn programma");
            string vraag0 = GetVraag(0);
            Console.WriteLine(vraag0);
            Vraag1();
            Vraag2();
            Vraag3();
            Vraag4();
            Vraag5();
            Vraag6();
            string antwoord7 = Vraag7();
            Console.WriteLine(antwoord7);

        }
        internal void Vraag1()
        {
            Console.WriteLine("How long do you think you'd survive in a zombie apocalypse?");
            string antwoord = Console.ReadLine();

            Console.WriteLine(antwoord);
        }
        internal void Vraag2()
        {
            Console.WriteLine("Why do round pizzas come in square boxes?");
            string antwoord = Console.ReadLine();

            Console.WriteLine(antwoord);
        }
        internal void Vraag3()
        {
            Console.WriteLine("Which species would be the rudest if all animals could talk?");
            string antwoord = Console.ReadLine();

            Console.WriteLine(antwoord);
        }
        internal void Vraag4()
        {
            Console.WriteLine("Has someone caught you dancing in front of the mirror?");
            string antwoord = Console.ReadLine();

            Console.WriteLine(antwoord);
        }

        internal void Vraag5()
        {
            Console.WriteLine("What is the worst game you played but that you liked anyway?");
            string antwoord = Console.ReadLine();

            Console.WriteLine(antwoord);
        }
        
        internal void Vraag6()
        {
            Console.WriteLine("What secret conspiracy would you like to actually start letting other people know?");
            string antwoord = Console.ReadLine();

            Console.WriteLine(antwoord);
        }

        internal string Vraag7()
        {
            Console.WriteLine("What would you call a male ladybug?");
            string antwoord = Console.ReadLine();

            return antwoord;

        }


     }
}
