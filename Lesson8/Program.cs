namespace Lesson8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Animal dog = new Animal("Bony", true, 15 , "haf-haf");
            //Animal cat = new Animal("Mur-Mur", true, 12, "miauuu");
            //Animal tiger = new Animal("Tiger", false, 30, "myr");
            //Voices(cat);

            //MainClass mClass= new MainClass();
            //mClass.MainMethod();

            //MainClass.NestedClass nClass = new MainClass.NestedClass();
            //nClass.NestedMethod();


            //MainClass.DerivedNedted drNested = new MainClass.DerivedNedted("Hello");
            //Console.WriteLine(drNested.GetField());
            //drNested.BaseMethod();

            ApartamentClass apartament1 = new ApartamentClass(Country.Armenia.ToString(), 
                City.Yerevan.ToString(), "Arshakunyac", 15, 85 , 70f);
            ApartamentClass apartament2 = new ApartamentClass(Country.Usa.ToString(), 
                City.Miami.ToString(), "Baxramyan", 56, 46 , 102.5f);
            ApartamentClass apartament3 = new ApartamentClass(Country.Georgia.ToString(),
                City.Batumi.ToString(), "Central", 85, 65, 50.5f);

            Print(apartament1);
            Print(apartament2);
            Print(apartament3);

            ApartamentClass.MaxSquare max = new ApartamentClass.MaxSquare();
            max.PrintCountry(apartament3);
            string maxSq = max.MaxSq(apartament3);
            Console.WriteLine(maxSq);

        }


        static void Print(ApartamentClass apartament)
        {
            Console.WriteLine(apartament.street);
        }

        static void Voices(Animal cat) 
        {
            Console.WriteLine( cat.voice.ToString());
        }

        enum Country
        {
            Armenia,
            Georgia,
            Usa
        }

        enum City
        {
            Yerevan,
            Ashtarak,
            Gyumri,
            Stepanavan,
            Tbilisi,
            Batumi,
            NewYork,
            Miami
        }
    }
}