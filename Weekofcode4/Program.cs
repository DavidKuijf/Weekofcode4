using System;

namespace Weekofcode4
{
    class Program
    {
        public class Entity { }
        public class Warrior : Entity { }
        public class Mage : Entity { }
        public class HugeWarrior : Warrior { }

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
            Console.WriteLine("Ik");
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
            for (int i = 0; i < 7; i++)
            {
                for (int a = 0; a < i; a++)
                {
                    Console.Write("\t");
                }
                Console.Write(bases[i] + "\n");
            }
        }

        static void Opdracht13()
        {
            //"description" : "Schrijf een programma dat op het scherm de tekst 'Programmeren is echt cool' afdrukt. Elk woord staat op een eigen regel en tussen de regels staat een witregel.", "requirements" : "Gebruik maximaal 5 regels en maximaal 2 keer '\\n'.",

            Console.WriteLine("Programmeren\n");
            Console.WriteLine("is\n");
            Console.WriteLine("echt");
            Console.WriteLine();
            Console.WriteLine("cool");
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
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine("        " + i + "\t|" + 2, 30 * i);
            }
        }

        //Ken de waarden volgende waarden toe aan de het juiste type variabele. De naam mag je zelf kiezen.\n1\ntrue\n3,678"
        static void Nummer16()
        {
            int op16 = 678;
        }

        //Ken de waarden volgende waarden toe aan de het juiste type variabele. De naam mag je zelf kiezen.\nfalse\n6,54\n\"Apenbal\""
        static void Nummer17()
        {
            string op17 = "Apenbal";
        }

        //Ken de waarden volgende waarden toe aan de het juiste type variabele. De naam mag je zelf kiezen.\n\"1,43\"
        static void Nummer18()
        {
            double op18 = 1.43;
        }

        //Sla de wortel van 8 op in een variabele. Je mag de waarde opzoeken.
        static void Nummer19()
        {
            double op19 = 2.82842712475;
        }

        //Maak een variabele die bijhoudt hoe oud iemand is, of zijn / haar ouders mee zijn en of hij /zij het zwembad in mag."
        static void Nummer20()
        {
            Console.WriteLine("Hoe oud ben je?");
            int op20 = Console.Read();
        }

        //Je hebt twee variabelen met een geheel getal (bijvoorbeeld 3 en 10). Wissel waarden van deze variabelen om. wat je programmeert moet werken bij elke inhoud van de variabelen."
        static void Nummer21()
        {
            int varA = 3;
            int varB = 10;
            Console.WriteLine("varA is " + varA);
            Console.WriteLine("varB is " + varB);
            int temp = varA;
            varA = varB;
            varB = temp;
            Console.WriteLine("varA is " + varA);
            Console.WriteLine("varB is " + varB);
        }

        // Maak een variabele waarin je de waarde van drie andere variabelen opgeteld worden. De eerste drie variabelen zijn 1 geheel getal en 2 komma-getallen.
        static void Nummer22()
        {
            int var1 = 10;
            double var2 = 9.99;
            double var3 = 0.11;
            Console.WriteLine("Totale waarde is " + (var1 + var2 + var3));
        }

        static void Nummer23()
        {
            int x = 10;
            int y = 20;
            int z = 30;
        }

        // "description" : "Schrijf een programma dat twee multiple choice vragen afdrukt en het antwoord op beide inleest.", "requirements" : "nvt (Gebruikers input kan niet getest worden in Genius@Work)"
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
            
           
            Console.WriteLine($"Give the answer to your question: {QUESTION}");
            double ANSWER = Double.Parse(Console.ReadLine());
            double ANSWER2 = ANSWER * 2;

            Console.WriteLine($"U gave this as answer: {ANSWER}, luckily you didn't answer {ANSWER2}");
        }

        static void Opdracht39()
        {
            Console.WriteLine("Enter a word. (Max 5 characters).");
            string WORD = Console.ReadLine();
            char[] WORD_ARRAY = WORD.ToCharArray();

            if (WORD.Length != 5)
            {
                Console.WriteLine("Error: the word entered is longer (or shorter) than 5 characters!");
            }

            foreach (char c in WORD)
            {
                Console.WriteLine(c + " ");
            }

            for (int i = WORD_ARRAY.Length; i > 0; i--)
            {
                Console.WriteLine(WORD_ARRAY[i] + " ");
            }
        }

        static void Opdracht40()
        {
            int RESULT = 0;
            Console.WriteLine("Enter a number between 100-500");
            string INPUT = Console.ReadLine();
            char[] ARRAY = INPUT.ToCharArray();

            foreach (char c in ARRAY)
            {
                int TMP = int.Parse(c.ToString());
                RESULT += TMP;
            }

            Console.WriteLine($"The sum of your number is: {RESULT}");
        }

        static void Opdracht41()
        {
            double ROUND_NUM;

            Console.WriteLine("Enter a decimal number.");
            double DEC_NUM = double.Parse(Console.ReadLine());

            Console.WriteLine("How do you want to round this number off? (ceil/floor/not)");
            string ANS = Console.ReadLine();

            if (ANS.Equals("ceil"))
            {
                ROUND_NUM = Math.Ceiling(DEC_NUM);
            }
            if (ANS.Equals("floor"))
            {
                ROUND_NUM = Math.Floor(DEC_NUM);
            }
            else
            {
                ROUND_NUM = DEC_NUM;
            }

            Console.WriteLine($"Your number: {ROUND_NUM}.");
        }

        static void Opdracht42()
        {
            Console.WriteLine("Is this question one?");
            string ANS1 = Console.ReadLine();
            if (Console.ReadKey().Key == ConsoleKey.LeftArrow || Console.ReadKey().Key == ConsoleKey.RightArrow || Console.ReadKey().Key == ConsoleKey.UpArrow || Console.ReadKey().Key == ConsoleKey.DownArrow)
            {
                Console.WriteLine("Is this question two?");
                string ANS2 = Console.ReadLine();

                if (Console.ReadKey().Key == ConsoleKey.LeftArrow || Console.ReadKey().Key == ConsoleKey.RightArrow || Console.ReadKey().Key == ConsoleKey.UpArrow || Console.ReadKey().Key == ConsoleKey.DownArrow)
                {
                    Console.WriteLine("Is this question three?");
                }
            }
        }

        static void Opdracht43()
        {
            string SENTENCE = Console.ReadLine();
            if (SENTENCE.Equals("Koekje van eigen deeg"))
            {
                Console.WriteLine("Koekje\tvan\teigen\tdeeg.");
            }

        }

        static void Opdracht44()
        {
            int ZERO_COUNT = 0;
            Console.WriteLine("Enter two numbers");
            string NUM1 = Console.ReadLine();
            string NUM2 = Console.ReadLine();
            
            foreach (char c in NUM1)
            {
                if (c.Equals("0"))
                {
                    ZERO_COUNT++;
                }
            }
            foreach (char c in NUM2)
            {
                if (c.Equals("0"))
                {
                    ZERO_COUNT++;
                }
            }

            if (ZERO_COUNT > 1)
            {
                Console.WriteLine(1);
            }
            else
            {
                Console.WriteLine(2);
            }
        }

        static void Opdracht45()
        {
            Console.WriteLine("Enter a word. (Max 5 characters).");
            string WORD = Console.ReadLine();
            char[] WORD_ARRAY = WORD.ToCharArray();

            if (WORD.Length != 5)
            {
                Console.WriteLine("Error: the word entered is longer (or shorter) than 5 characters!");
            }

            Console.WriteLine("Enter a seperation mark");
            string MARK = Console.ReadLine();

            for (int i = WORD_ARRAY.Length; i > 0; i--)
            {
                Console.WriteLine(WORD_ARRAY[i] + MARK);
            }
        }

        static void Opdracht46()
        {
            //"description" : "Cast float naar int.", "requirements" : "Pas de regel niet aan, maar doe de cast op een nieuwe regel met een nieuwe int variabele",
            float damage = 231.99f;
            int damageint = (int)damage;
            Console.WriteLine(damageint);
        }

        static void Opdracht47()
        {
            int a = 5;
            int b = 2;
            float c = (float)a / b; //FIXME: This calculation is incorrect\n\t}\n}",
            Console.WriteLine(c);
        }

        static void Opdracht48()
        {
            //"description" : "Cast \"int answer = 42\" naar een double.", "requirements" : "Pas de regel \"int answer = 42\" niet aan, maar cast hem op de regel eronder naar een nieuwe double", "
            int answer = 42;
            double doubleAnswer = answer;
        }

        static void Opdracht49()
        {
            char firstLetter = 'a';
            int intLetter = (int)firstLetter;
            Console.WriteLine(intLetter);
        }

        static void Opdracht50()
        {
            int b = 98;
            char castChar = (char)b;
            Console.WriteLine(castChar);
        }

        static void Opdracht51()
        {
            string price = "12.95";
            double doubleprice = Convert.ToDouble(price);
            Console.WriteLine(doubleprice);
        }

        static void Opdracht52()
        {
            bool won = true;
            string castBool = won.ToString();
            Console.WriteLine(castBool);
        }
        static void Opdracht53()
        {
            ulong copper = 87253321654;
            Int64 copperstring = Convert.ToInt64(copper);
          
            //Console.WriteLine(intCopper);


        }

        static void Opdracht54()
        {
            int bineary = 0b101010;
            string integer = bineary.ToString();
            Console.WriteLine(bineary);
        }

        static void Opdracht55()
        {
            int palindrome = 10101;
            int palindrome2 = (int)palindrome;

        }

        static void Opdracht56()
        {
            Warrior Henk = new Warrior();
            if (Henk is Entity) {
                //FIXME: Do smart stuff here
                System.Console.WriteLine("Henk de Warrior is een entity");
            }
            else System.Console.WriteLine("Henk de Warrior is helemaal geen entity");

        }

        static void Opdracht57()
        {
            Mage Piet = new Mage(); //Piet the mighty mage!! OMG
            Entity EntPiet = (Entity)Piet;
        }

        static void Opdracht58()
        {
            string enemyIsDead = "true";
            bool enemyIsDeadBool = bool.Parse(enemyIsDead);
            Console.WriteLine(enemyIsDeadBool);
        }

        static void Opdracht59()
        {
            int? veryHard = null;
            long? longVeryHard = (long?)veryHard;
            Console.WriteLine(longVeryHard);
        }

        static void Opdracht60()
        {
            Warrior Henk = new Warrior();
            if (Henk is Entity)
            { //FIXME: Do smart stuff here 
                System.Console.WriteLine("Henk de HugeWarrior is nog steeds een entity");
            }
            else { System.Console.WriteLine("Henk de HugeWarrior is helemaal geen entity)"); }
        }

        static void Opdracht61()
        {
            string hello = "hello";
            string world = "world";

            string hw = hello + " " + world + "!";
            Console.WriteLine(hw);
        }
        static void Opdracht62()
        {
            int hp = 100;
            Console.WriteLine("the enemy has " + hp+ "hp left" );
        }
        static void Opdracht63()
        {
            string name = "Eldan";
            string friend = "eldan";
            if (name.Equals(friend))
            {
                Console.WriteLine("these are equal");
            }
        }
        static void Opdracht64()
        {
            string name = "Eldan";
            string friend = "eldan";
            if (name.Equals(friend, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("these are equal");
            }
        }
        static void Opdracht65()
        {
            string name = "Eldan";
            string text1 = "Welcome";
            string text2 = ", lets start saving the world!!";
            string final1 = text1 + " " + name + text2;
            Console.WriteLine(final1);
            string final2 = String.Format("{0} {1} {2}", text1, name, text2);
            Console.WriteLine(final2);

        }
        static void Opdracht66()
        {
            for (int i=0; i < 10; i++)
            {
                Console.WriteLine("File("+i+").exe");
            }
        }
        static void Opdracht67()
        {
            string input = "The enemy wizard has died";
            string replace = input.Replace("wizard has died","warrior is alive");
            Console.WriteLine(replace);
        }
        static void Opdracht68()
        {

            string[] array = { "123.45", "9.95", "19.99","12", "99.9" };
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = String.Format("{0,10:C}", array[i]);
                Console.WriteLine(array[i]);
            }

        }
        static void Opdracht69()
        {
            string[] array = { "Call of Duty", "World of Warcraft", "Starcraft 2", "Fallout 4", "Grand Theft Auto" };
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = String.Format("{0,18}", array[i]);
                Console.WriteLine(array[i]);
            }
        }

        static void Opdracht70()
        {
            string strings = "Llane Wrynn was the ruler of the Kingdom of Azeroth during the First War";
            string[] cutstring = strings.Split(" ");
            string one = cutstring[3];
            string two = cutstring[4];
            cutstring[3] = two;
            cutstring[4] = one;
            Console.WriteLine( String.Join(" ", cutstring));

            
        }
        
        static void Opdracht71()
        {
            string input = "The Lich King is the master and lord of the Scourge";
            string[] cutstring = input.Split(" ");

            string[] swapstring = new string[15];
            for(int i = 0 ; i < cutstring.Length; i++)
            {
                int current = cutstring.Length-1 - i;
                swapstring[i] = cutstring[current];
            }

            string output = String.Join(" ", swapstring);
            System.Console.WriteLine(output);
        }

        static void Opdracht72()
        {
            string input = "The fierce warrior Eldan has slain the might demon Kil'jaeden";
            string[] cutstring = input.Split(" ");
            Console.WriteLine(cutstring[4]);
        }

        static void Opdracht73()
        {
            int number = 123;
            Console.WriteLine( String.Format("123 {0} {1}", number.ToString("X"), Convert.ToString(number, 2)));
        }
        static void Opdracht74()
        {
            string input = "Onyxia is the current broodmother of the Black Dragonflight";
            try
            {
                Console.WriteLine(input[333]);
            }
            catch
            {
                Console.WriteLine("index oveflow");
            }
        }
        
        /*static void Opdracht75()
        {
            string input = "This is still readable";
            UTF8Encoding utf8 = new UTF8Encoding();
            string unicodeString = "Quick brown fox";
            byte[] encodedBytes = utf8.GetBytes(unicodeString);

            //source:https://stackoverflow.com/questions/8707759/how-to-convert-a-string-to-utf8

        }*/

        static void Opdracht76()
        {
            int x = 10;
            double y = 2.3;
            int z = x + (int)y;
            Console.WriteLine(z);
        }
        static void Opdracht77()
        {
            int x = 10;
            double y = 2.3;
            double z = (x * y) / 3;
            Console.WriteLine(z);
        }
        static void Opdracht78()
        {
            //Tel bij x 1 op, deel dat door y en sla dat op in x, waarbij je afrond naar beneden
            int x = 10;
            double y = 2.3;
            x = (x + 1);
            x = x / y;

            Console.WriteLine(x);
           
        }
        static void Opdracht79()
        {


        }
        static void Opdracht80()
        {

        }




        static void Main(string[] args)

        {

            /* Opdracht1(); CHECKED
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
             Opdracht15();*/

            /*Nummer16(); NEEDS CHECKING
            Nummer17();
            Nummer18();
            Nummer19();
            Nummer20();
            Nummer21();*/
            Nummer22();

            /* Opdracht31(); CHECKED
             Opdracht32();
             Opdracht33();
             Opdracht34();
             Opdracht35();*/

            /*Opdracht36(); //NEEDS CHECKING
              Opdracht37();
              Opdracht38();
              Opdracht39();*/

            /*Opdracht46(); //NEEDS CHECKING
            Opdracht47();
            Opdracht48();
            Opdracht49();
            Opdracht50();*/

            /*Opdracht51(); //NEEDS CHECKING
            Opdracht52();
            Opdracht53();
            Opdracht54();*/
            Opdracht55();

            /*Opdracht56(); //NEEDS CHECKING
            Opdracht57();
            Opdracht58();
            Opdracht59();
            Opdracht60();*/

            /*Opdracht61();
            Opdracht62();
            Opdracht63();
            Opdracht64();
            Opdracht65();*/

            /* Opdracht66();
             Opdracht67();
             Opdracht68();
             Opdracht69();
             Opdracht70();*/

            /*Opdracht71();
            Opdracht72();
            Opdracht73();
            Opdracht74();
            Opdracht75();*/

            Opdracht76();
            Opdracht77();
            Opdracht78();
            Opdracht79();
            Opdracht80();

            Console.ReadKey();
        }
    }
}
