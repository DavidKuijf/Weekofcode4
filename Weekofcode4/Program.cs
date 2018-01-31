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

        static void Opdracht13()
        {
            //"description" : "Schrijf een programma dat op het scherm de tekst 'Programmeren is echt cool' afdrukt. Elk woord staat op een eigen regel en tussen de regels staat een witregel.", "requirements" : "Gebruik maximaal 5 regels en maximaal 2 keer '\\n'.",

            Console.WriteLine("Programmeren\n\n is\n\n echt\n\n cool");
        }

        static void Opdracht14()
        {
            // "description" : "Druk op het scherm de volgende tekst af: 'Een, twee, drie, vier, hoedje van, hoedje van, een twee, drie, vier, hoedje van papier'. Elk woord staat op een eigen regel. Na elke woord spring je verder in. Na 4 woorden verandert de richting (dus van verder, naar minder ver inspringen of andersom).", "requirements" : "Gebruik 1 regel code.", 
            Console.WriteLine("Een,\n\t twee,\n\t\t drie,\n\t\t\t vier,\n\t\t\t\t hoedje\n\t\t\t van,\n\t\t hoedje\n\t van,\n een\n\t twee,\n\t\t drie,\n\t\t\t vier,\n\t\t\t\t hoedje\n\t\t\t van\n\t\t papier\n\t\t");
        }
        static void Opdracht15()
        {
            //"description" : "1 Festival muntje kost 2,30. Druk op het scherm een tabel af waarin je aangeeft hoe duur 1 t/m 10 muntjes zijn. Natuurlijk is de eerste regel een kopregel en de tweede een scheidingslijn (meerdere '-').", "requirements" : "nvt",
            Console.WriteLine("Aantal muntjes \t| Prijs");
            Console.WriteLine("----------------------");
            for(int i = 1; i<11; i++)
            {
                Console.WriteLine("        " + i +"\t|" + 2,30*i);
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

        static void Opdracht32()
        {
            Console.WriteLine("What's your first name?");
            string FIRST_NAME = Console.ReadLine();
            Console.WriteLine("What's your last name?");
            string LAST_NAME = Console.ReadLine();
            Console.WriteLine("What's your postal code?");
            string POSTAL_CODE = Console.ReadLine();
        }

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

            Console.ReadKey();
        }
    }
}
