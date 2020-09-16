using System;

namespace Textgame
{
    class Program
    {
        static void Main(string[] args)
        {

            static void QuestionA()
            {
                Console.WriteLine("Wake the fuck up samurai, we have a city to burn!");

                Console.WriteLine("(Why? / Who are you?)");
            }

            static void QuestionAB()
            {
                Console.WriteLine("The damn snakes have come back for us and have made Shanghai their nest. We are left no choice but to burn it down to it's core");

                Console.WriteLine("Will you support me in this venture?");

                Console.WriteLine("(Yes / No)");
            }

            static void QuestionAC()
            {
                Console.WriteLine("I'm Keanu Reeves but cooler. I don't understand why this is relevant to our issue.");

                Console.WriteLine("(Can I have your autograph? / Matrix 4 when?)");
            }

            //Program asks for a response

            QuestionA();

            string responseburn;

            responseburn = Console.ReadLine();

            if (responseburn == "Why?")
            {
                QuestionAB();

                string help = Console.ReadLine();

                if (help == "Yes")
                {
                    Console.WriteLine("Well what are you waiting for? Get the fuck up and come with me!");

                }
                else if (help == "No")
                {
                    Console.WriteLine("Excuse me? *Throws you 200 meters in the air, your head splits open as you land*");
                }
                else
                {
                    Console.WriteLine("I don't speak jibberish *Slices off your left hand with inhuman speed");
                }
            }
            if (responseburn == "Who are you?")
            {
                QuestionAC();

                string fanresponse = Console.ReadLine();

                if (fanresponse == "Can I have your autograph?")
                {
                    Console.WriteLine("*sigh* I knew this would happen. You are of no use for me anymore *Stabs you in the throat*");
                }
                else if (fanresponse == "Matrix 4 when?")
                {
                    Console.WriteLine("Glad you asked. I'll hand you a free movie ticket if you would stop being so annoying.");
                }
                else
                {
                    Console.WriteLine("You would be of more use if you weren't talking like you have a potato down your throat");
                }
            }

            Console.ReadLine();
        }
    }
}


