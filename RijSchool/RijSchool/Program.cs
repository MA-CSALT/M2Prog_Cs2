namespace RijSchool
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
            Auto auto1 = new Auto()
            {
                automaat = true,
                kenteken ="AA824H",
                kilometerStand= 20567,
                merk="volkwagen"
            };

            Auto auto2 = new Auto()
            {
                automaat = false,
                kenteken = "KU786G",
                kilometerStand = 65739,
                merk = "volvo"
            };

            RijLeraar rijLeraar = new RijLeraar()
            {
                leeftijd=30,
                naam="John",
                zzp= false
            };

            LesPakket lesPakket = new LesPakket()
            {
                urenGekocht = 14,
                urenVerbruikt = 12,
                examenPogingen = 3,
                automaat=false
            };

            TheorieTest theorieTest = new TheorieTest()
            {
                aantalFouten = 2,
                gehaald = true,
                afnameDatum= new DateTime(2020, 4, 15)
            };

            RijTest rijTest = new RijTest()
            {
                gehaald= false,
                afnameDatum = new DateTime(2021, 1, 3)
            };

            Student student1 = new Student()
            {
                naam = "Nick",
                leeftijd= 18,
                lesPakket= lesPakket,
                theorieTest= theorieTest,
                rijTest = rijTest
            };

            Student student2 = new Student()
            {
                naam = "Finn",
                leeftijd= 20,
            };

            LesUur lesUur = new LesUur()
            {
                auto = auto1,
                rijLeraar = rijLeraar,
                student = student1,

                tijd = 1130
            };
        }
   
    }
}
