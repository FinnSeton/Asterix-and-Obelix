using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace ConsoleApp1
{
    internal class Program
    {
        static void daum(string[] args)
        {
            /* 
            char myLetter = 'D'; voor losse characters
            bool myBool = true; boolean spreekt voor zichzelf
            */
 
            // een lijst met waardes en verschillende variables dat werkt door ','
            int x = 5, y = 6, z = 50;
            Console.WriteLine(x + y + z);
 
            // omdat de volgende een ReadLine is, Werkt dit nu hetzelfde als een input
            Console.WriteLine("Enter username:");
 
            // maakt een string variable en pakt de user input van je keyboard en slaat het op in de variable
            string userName = Console.ReadLine();
 
            // print de waarde van de variable userName, en dat laat de input value zien
            Console.WriteLine("Username is: " + userName);
 
            Console.WriteLine("Enter your age:");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your age is: " + age);
 
            int num = 15;
            Console.WriteLine(num);
 
            // long nummer moet eindigen met 'L' gebruik dit wanneer absurt hoog/laag nummer. 
            long myNum = 15000000000L;
            Console.WriteLine(myNum);
 
            // eindig een float met een 'F' dit werkt tot 7 decimalen. 
            float myFloat = 5.75F;
            Console.WriteLine(myFloat);
 
            // eindig een double met een 'D' dit werkt tot 15 decimalen. 
            double myDouble = 19.99D;
            Console.WriteLine(myDouble);
 
            // de 'e' in de int staat voor tot de macht van 10. 
            float f1 = 35e3F;
            double d1 = 12E4D;
            Console.WriteLine(f1);
            Console.WriteLine(d1);
 
            // boolean voorbeelden 
            bool isCSharpFun = true;
            bool isFishTasty = false;
            Console.WriteLine(isCSharpFun);   // Outputs True
            Console.WriteLine(isFishTasty);   // Outputs False
 
            // 1 character voorbeeld
            char myGrade = 'B';
            Console.WriteLine(myGrade);
 
            int myIntConvert = 10;
            double myDoubleConvert = 5.25;
            bool myBoolConvert = true;
 
            // voorbeelden van converts
            Console.WriteLine(Convert.ToString(myIntConvert));    // convert int to string
            Console.WriteLine(Convert.ToDouble(myIntConvert));    // convert int to double
            Console.WriteLine(Convert.ToInt32(myDoubleConvert));  // convert double to int
            Console.WriteLine(Convert.ToString(myBoolConvert));   // convert bool to string
 
            /*
            Lijst met operators
            + = plus
            - = min
            * = keer
            / = delen
            % = delen en laten zien wat er overblijft
            ++ = +1 voor een variable
            -- = -1 voor een variable
 
            comparison operators
            == = gelijk aan
            != = niet gelijk aan
> = grooter dan
< = kleiner dan
>= grooter of gelijk aan
<= kleiner of gelijk aan
 
            logical operators
&& = Geeft 'True' terug als ze beide waar zijn
            || = Geeft 'True' terug als er 1 waar is
            ! = Geeft 'False' terug wanneer het klopt
             */
 
            // geeft iy terug
            int ix = 10;
            int iy = 20;
            Console.WriteLine(Math.Max(ix, iy));
 
            // lengte van een string vinden met .Length
            string txt = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            Console.WriteLine("The length of the txt string is: " + txt.Length);
 
            // de eerste is in alles CAPS, de tweede alles lowercase.
            string text = "Hello world!";
            Console.WriteLine(text.ToUpper());
            Console.WriteLine(text.ToLower());
 
            // betere techniek om twee strings samen te voegen
            string firstName = "Cas";
            string lastName = "Euser";
            string name = $"My full name is: {firstName} {lastName}";
            Console.WriteLine(name);
 
            // geeft de letter 'H' terug, de brackets laten het index van het nummer zien
            string myString = "Hello";
            Console.WriteLine(myString[0]);
 
            // geeft 1 terug, werkt de andere kant op als de vorige
            string mystring = "Hello";
            Console.WriteLine(mystring.IndexOf("e"));
 
            /*
             voor speciale strings zoals dingen tussen quotes zetten hebben we deze 3 voorbeelden
            \'Woord\' voor single quotes
            \"Woord\" voor double quotes
            \\Woord\\ voor een backslash
 
            Mocht maar 1 kleine quote nodig gebruik je het zo:
            "it\'s alright
             */
 
            string viking = "We are the so-called \"Vikings\" from the north.";
            Console.WriteLine(viking);
 
            int MijnLeeftijd = 25;
            int stemLeeftijd = 18;
 
            if (MijnLeeftijd >= stemLeeftijd)
            {
                Console.WriteLine("oud genoeg");
            }
            else
            {
                Console.WriteLine("nog niet oud genoeg");
            }
 
            // simpele voorbeelden van if, else if, else
            int time = 22;
            if (time < 10)
            {
                Console.WriteLine("Good morning.");
            }
            else if (time < 20)
            {
                Console.WriteLine("Good day.");
            }
            else
            {
                Console.WriteLine("Good evening.");
            }
 
            /*short Hand If...Else (Ternary Operator), werkt hetzelfde als een if
 
              variable = (condition) ? expressionTrue(if) : expressionFalse(else);
              */
            int tijd = 20;
            string result = (tijd < 18) ? "Good day." : "Good evening.";
            Console.WriteLine(result);
 
            // voorbeeld switch functie, het kijkt naar de int en voert het blok uit met dezelfde waarde, dus in dit geval 'Thursday'
            // default zorgt ervoor dat als de int niet overeenkomt met een case, dat hij dan de default als waarde geeft.
            int day = 4;
            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Looking forward to the next day.");
                    break;
            }
            // basic while loop in C#
            int i = 0;
            while (i < 5)
            {
                Console.WriteLine(i);
                i++;
            }
 
            // do/while loop, het voert het sowieso 1x uit, omdat het blok eerder word getest dan gechecked
            int g = 0;
            do
            {
                Console.WriteLine(g);
                g++;
            }
            while (g < 5);
 
            // basic for loop in C#
            for (int d = 0; d < 5; d++)
            {
                Console.WriteLine(d);
            }
 
            // Een 'nest loop' dit is de buiten loop. Het is gewoon een loop in een loop
            for (int r = 1; r <= 2; ++r)
            {
                Console.WriteLine("Outer: " + r);  // 2x gedaan
 
                // de binnen loop
                for (int j = 1; j <= 3; j++)
                {
                    Console.WriteLine(" Inner: " + j); // 6x gedaan (want 2*3)
                }
            }
 
            // foreach haalt elementen uit arrays. je maakt een array door type[] 'naam' = {cas, john, gert};
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            foreach (string b in cars)
            {
                Console.WriteLine(b);
            }
 
            // een voorbeeld met een break, hij stopt nu bij 4.
            for (int f = 0; f < 10; f++)
            {
                if (f == 4)
                {
                    break;
                }
                Console.WriteLine(f);
            }
 
            // een voorbeeld met continue, hij slaat 4 nu over.
            for (int q = 0; q < 10; q++)
            {
                if (q == 4)
                {
                    continue;
                }
                Console.WriteLine(q);
            }
            // het werkt ook met een while loop, dit is de continue
            int t = 0;
            while (t < 10)
            {
                if (t == 4)
                {
                    t++;
                    continue;
                }
                Console.WriteLine(t);
                t++;
            }
            // hier de break met de while loop
            int v = 0;
            while (v < 10)
            {
                Console.WriteLine(v);
                v++;
                if (v == 4)
                {
                    break;
                }
            }
 
            // de sort functie doet het op alfabetische volgorde
            string[] auto = { "Volvo", "BMW", "Ford", "Mazda" };
            Array.Sort(auto);
            foreach (string I in auto)
            {
                Console.WriteLine(I);
            }
 
            // werkt ook met nummers vanaf 1 laten oplopen
            int[] myNumbers = { 5, 1, 8, 9 };
            Array.Sort(myNumbers);
            foreach (int V in myNumbers)
            {
                Console.WriteLine(V);
            }
            // 2 dimensional variables. dit output 2 want in de [0,2], gaat het rij, en dan column.
            int[,] numbers = { { 1, 4, 2 }, { 3, 6, 8 } };
            Console.WriteLine(numbers[0, 2]);  // Output 2
            Console.Read();
        }
    }
}