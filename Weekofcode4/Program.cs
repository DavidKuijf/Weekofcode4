using System;

namespace Weekofcode4
{
    class Program
    {
        static void Opdracht1()
        {
            //"Schrijf een programma dat op het scherm de tekst: 'Week of Code rocks!' afdrukt.", "requirements" : "nvt",
            Console.WriteLine("Week of Code rocks!");
        }

        static void Opdracht2()
        {
            //"description" : "Schrijf een programma dat op het scherm de tekst 'Ik ben springerig' afdrukt, waarbij ieder woord op een eigen regel staat.", "requirements" : "nvt"
            Console.WriteLine(" Ik \n ben \n springerig"); 
        }

        static void Opdracht3()
        {
            //"description" : "Schrijf een programma dat op het scherm de tekst 'Ik doe extra werk' afdrukt.", "requirements" : "Gebruik per woord een eigen regel code."
            Console.WriteLine(" Ik");
            Console.WriteLine(" Doe");
            Console.WriteLine(" Extra");
            Console.WriteLine(" Werk");
        }

        static void Opdracht4()
        {
            //"description" : "Schrijf een programma dat op het scherm de tekst 'Twee regels' afdrukt, waarbij ieder woord op een eigen regel staat.", "requirements" : "Gebruik 1 regel code"
            Console.WriteLine(" Twee\n regels");
        }

        static void Opdracht5()
        {
            //"description" : "Schrijf een programma dat op het scherm de tekst 'Tabbladen zijn gaaf' afdrukt, waarbij ieder woord gescheiden is door een tab.", "requirements" : "nvt"
            Console.WriteLine(" Tabbladen\tzijn\tgaaf");
        }

        static void Opdracht6()
        {
            //"description" : "Schrijf een programma dat op het scherm de tekst 'Kijk mama, zonder gegeven code!' afdrukt.", "requirements" : "nvt"
            Console.WriteLine("Kijk mama, zonder gegeven code!' afdrukt.");
        }

        static void Opdracht7()
        {
            //"description" : "Druk op het scherm af: 'Ik verzamel vandaag de meeste achievements'. Elk woord staat op een eigen regel.", "requirements" : "Gebruik om de beurt write en writeline.", 
            Console.WriteLine( "Ik");
            Console.Write("verzamel\n");
            Console.WriteLine("vandaag");
            Console.Write("de\n");
            Console.WriteLine("meeste");
            Console.Write("achievements\n");

        }
        static void Opdracht8()
        {
            //"description" : "Druk op 1 regel de tekst 'tab, tab, tab, die mooie tab van goud.' af, gescheiden door tabs.", "requirements" : "Elke '\\t' staat op een eigen regel."
            Console.WriteLine("tab,\t" +
                "tab,\t" +
                " tab,\t" +
                " die mooie tab van goud.");
        }
        static void Opdracht9()
        {
            //"description" : "Druk onder elkaar de woorden 'één' tot en met 'tien' af.", "requirements" : "Gebruik enkel write."
            Console.Write("Een\n");
            Console.Write("Twee\n");
            Console.Write("Drie\n");
            Console.Write("Vier\n");
            Console.Write("Vijf\n");
            Console.Write("Zes\n");
            Console.Write("Zeven\n");
            Console.Write("Acht\n");
            Console.Write("Negen\n");
            Console.Write("Tien\n");
        }
        static void Opdracht10()
        {
            //"description" : "'Ik hou van witregels' komt op het scherm, waarbij ieder woord op een eigen regel staat, met witregels ertussen.", "requirements" : "Gebruik geen '\\n'"
            Console.WriteLine("Ik");
            Console.WriteLine();
            Console.WriteLine("hou");
            Console.WriteLine();
            Console.WriteLine("van");
            Console.WriteLine();
            Console.WriteLine("witregels");
        }

        static void Opdracht11()
        {
            //"description" : "Op het scherm komt de tekst: 'C# is beter dan Java'.Alle woorden zijn gescheiden door tabs.", "requirements" : "Gebruik enkel writeline."
            Console.WriteLine("C#\tis\tbeter\tdan\tJava");
        }

        static void Opdracht12()
        {
            //"description" : "Op het scherm verschijnt de tekst 'all your base are belong to us'. Ieder woord staat op een eigen regel en springt verder in.", "requirements" : "Gebruik maximaal 1 keer '\\t' en maximaal 1 keer '\\n'.", 
           
            String[] bases = { "all", "your", "base", "are", "belong", "to", "us" };
            for (int i =0; i < 7; i++)
            {
                for (int a = 0; a < i; a++)
                {
                    Console.Write("\t");
                }
                Console.Write(bases[i]+"\n");
            }
        }

        static void Opdracht31()
        {
            Console.WriteLine("What is 1+1?");
            Console.WriteLine("A. 1");
            Console.WriteLine("B. 2");
            Console.WriteLine("C. 3");
            string ans = Console.ReadLine();

            Console.WriteLine("What's the capital of the Nederlands?");
            Console.WriteLine("A. Rotterdam");
            Console.WriteLine("B. Amsterdam");
            Console.WriteLine("C. Den Haag");
            string ans2 = Console.ReadLine();

        }

        // "description" : "Schrijf een programma dat een voornaam, achternaam en postcode inleest. Druk zelf ook de vragen af.", "requirements" : "nvt (Gebruikers input kan niet getest worden in Genius@Work)"
        static void Opdracht32()
        {
            Console.WriteLine("What's your first name?");
            string FIRST_NAME = Console.ReadLine();
            Console.WriteLine("What's your last name?");
            string LAST_NAME = Console.ReadLine();
            Console.WriteLine("What's your postal code?");
            string POSTAL_CODE = Console.ReadLine();
        }

        // "description" : "Breidt het vorige programma uit zodat ook een huisnummer, gewicht en inkomen (in euro's) wordt opgevraagd.", "requirements" : "nvt (Gebruikers input kan niet getest worden in Genius@Work)"
        static void Opdracht33()
        {
            Console.WriteLine("What's your first name?");
            string FIRST_NAME = Console.ReadLine();

            Console.WriteLine("What's your last name?");
            string LAST_NAME = Console.ReadLine();

            Console.WriteLine("What's your postal code?");
            string POSTAL_CODE = Console.ReadLine();

            Console.WriteLine("What's your house number?");
            string HOUSE_NUMBER = Console.ReadLine();

            Console.WriteLine("How much do you weigh?");
            string WEIGHT = Console.ReadLine();

            Console.WriteLine("How much do you earn (in euros)?");
            string EARNINGS = Console.ReadLine();
        }

        // "description" : "Vraag de gebruikers twee gehele getallen in te typen. Wissel deze om en druk ze weer af met begeleidende tekst.", "requirements" : "nvt (Gebruikers input kan niet getest worden in Genius@Work)"
        static void Opdracht34()
        {
            Console.WriteLine("Enter two whole numbers.");
            string NUMBER1 = Console.ReadLine();
            string NUMBER2 = Console.ReadLine();
            Console.WriteLine($"Your numbers are: {NUMBER1}, {NUMBER2}.");
            Console.WriteLine("Now we'll swap them...");
            Console.WriteLine($"Here are your numbers again: {NUMBER2}, {NUMBER1}.");
        }

        // "description" : "Vraag de gebruiker twee getallen (evt kommagetallen) in te lezen. Druk de som ervan af op het scherm.", "requirements" : "nvt (Gebruikers input kan niet getest worden in Genius@Work)"
        static void Opdracht35()
        {
            Console.WriteLine("Enter two numbers.");
            double NUMBER1 = Double.Parse(Console.ReadLine());
            double NUMBER2 = Double.Parse(Console.ReadLine());
            double SUM = NUMBER1 + NUMBER2;
            Console.WriteLine("The sum of your numbers: " + SUM);
        }

        // "description" : "Vraag de gebruiker of hij /zij al 18 is en of hij / zij gedronken heeft.\nSla deze informatie op in een boolean.", "requirements" : "nvt (Gebruikers input kan niet getest worden in Genius@Work)"
        static void Opdracht36()
        {
            bool ABOVE_AGE = false;
            bool DRUNK = false;

            Console.WriteLine("Are you 18 years or older?\na. yes\nb. no");
            string AGE_INPUT = Console.ReadLine();
            if (AGE_INPUT.Equals("a") || AGE_INPUT.Equals("A"))
            {
                ABOVE_AGE = true;
            }

            Console.WriteLine("Have you consumed alcohol before?\na. yes\nb. no");
            string ALC_INPUT = Console.ReadLine();
            if (ALC_INPUT.Equals("a") || ALC_INPUT.Equals("A"))
            {
                DRUNK = true;
            }

            Console.WriteLine($"Here are your answers:\n18 or older, {ABOVE_AGE}\nDrunk before, {DRUNK}");
        }

        // "description" : "De gebruiker vult een tekst in en een auteur. Op het scherm komt de tekst:\n\"Uw favoriete gedicht is: {hier de tekst van de gebruiker}, maar ik hou van niet van {auteur van de gebruiker}\""
        static void Opdracht37()
        {
            Console.WriteLine("Enter a text.");
            string POEM = Console.ReadLine();
            Console.WriteLine("Enter an author.");
            string AUTHOR = Console.ReadLine();

            Console.WriteLine($"Your favourite poem is: {POEM}, but I don't like {AUTHOR}.");
        }

        // "description" : "Lees van de gebruiker in welke vraag hij / zij graag wil beantwoorden. Druk op het scherm af:\n\"Geef het antwoord op vraag {ingevulde vraag}.\" Het antwoord op de vraag is een getal.\nTel de vraag en het antwoord op en druk op het scherm af:\n\"u gaf op vraag {vraag van gebruiker} niet het antwoord {resultaat van jouw som}. Gelukkig maar!\""
        static void Opdracht38()
        {
            Console.WriteLine("Enter a question.");
            string QUESTION = Console.ReadLine();
            char[] ARRAY = QUESTION.ToCharArray();
            for (int i = 0; i < ARRAY.Length; i++)
            {
                if (ARRAY[i] is double)
                {

                }
            }
            Console.WriteLine($"Give the answer to your question: {QUESTION}");
            double ANSWER = Double.Parse(Console.ReadLine());


        }

        static void Main(string[] args)
        {

            Opdracht1();
            Opdracht2();
            Opdracht3();
            Opdracht4();
            Opdracht5();
            Opdracht6();
            Opdracht7();
            Opdracht8();
            Opdracht9();
            Opdracht10();
            Opdracht11();
            Opdracht12();
            Opdracht13();
            Opdracht14();
            Opdracht15();

            Opdracht31();
            Opdracht32();
            Opdracht33();
            Opdracht34();
            Opdracht35();
            Opdracht36();
            Opdracht37();

            Console.ReadKey();
        }
    }
}
