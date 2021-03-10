using System;
using static System.Console;

namespace VirtualZooFinal
{
    class World
    {
        public World()
        {
            Title = "crypto zoo";
            WriteLine(@"                       _                         
                      | |                        
  ___ _ __ _   _ _ __ | |_ ___    _______   ___  
 / __| '__| | | | '_ \| __/ _ \  |_  / _ \ / _ \ 
| (__| |  | |_| | |_) | || (_) |  / / (_) | (_) |
 \___|_|   \__, | .__/ \__\___/  /___\___/ \___/ 
            __/ | |                              
           |___/|_|                            ");

            WriteLine("\nwelcome to my zoo!");
            WriteLine("we got a 256 bits of animal fun");
            WriteLine("\nwhat would ya like to behold?");

            VirtualPet bimba = new VirtualPet("i is bimba, yr guide deer", ConsoleColor.Gray, "i can show ya round");

            bimba.Greet();
            bimba.Draw();

            WriteLine("\nwhat would you like to see first?");
            WriteLine("\ntype 1 for hedgehog, 2 for a gator, or 3 for a lazy ass leopard");
            WriteLine("an press enter");

            string input = ReadLine();

            CryptoZoo(input);


        }



        private void CryptoZoo(string input)
        {
            DecorStorage dec = new DecorStorage();

            if (input == "1")
            {

                WriteLine("\ngaze upon the prehistoric hedgehog...");
                dec.DrawFenceWithPerson();

                HedgeHog hh = new HedgeHog(
                    "we is otto an' silvia",
                    ConsoleColor.DarkRed,
                    "we scurry all night in the bushes",
                    "we is 8 inches tall stacked",
                    "and we's moove like ninja in tha darkness");

                hh.Greet();
                hh.DrawHedgeHog();

                WriteLine("\nwhat would you like to see next?");
                WriteLine("\ntype 1 for hedgehog, 2 for a gator, or 3 for a lazy ass leopard, 4 to exit");

                input = ReadLine();

                CryptoZoo(input);

            }
            else if (input == "2")
            {
                WriteLine("\nbask in the muddy shimmering unkown...");
                dec.DrawFenceWithPerson();

                Gator gator = new Gator(
                    "i is sal",
                    ConsoleColor.DarkGreen,
                    "i lurks in the murks",
                    "i done ate 4.5 kayakers, plus a few fingers and toes",
                    "my current stealth rating is \'death\'");

                gator.Greet();
                gator.DrawGator();

                WriteLine("\nwhat would you like to see next?");
                WriteLine("\ntype 1 for hedgehog, 2 for a gator, or 3 for a lazy ass leopard, 4 to exit");

                input = ReadLine();

                CryptoZoo(input);

            }
            else if (input == "3")
            {
                WriteLine("\npeer into the peepers of a leopard...");
                dec.DrawFenceWithPerson();

                Leopard leopard = new Leopard(
                    "i am lenny",
                    ConsoleColor.DarkMagenta,
                    "i lounge lazily",
                    "i\'ve munched a mess of those mischevuious monkees",
                    "my longest sleep lasted days");

                leopard.Greet();
                leopard.DrawLeopard();

                WriteLine("\nwhat would you like to see next?");
                WriteLine("\ntype 1 for hedgehog, 2 for a gator, or 3 for a lazy ass leopard, 4 to exit");
                input = ReadLine();
                CryptoZoo(input);
            }
            else if (input == "4")
            {
                dec.DrawExit();

                WriteLine("\npress any key to exit");
                ReadKey(true);
            }
            else
            {
                VirtualPet bimba = new VirtualPet("", ConsoleColor.Gray, "\nentered something wrong, try again dumdum...");
                bimba.Greet();
                bimba.Draw();
                WriteLine("\ntype 1 for hedgehog, 2 for a gator, or 3 for a lazy ass leopard, 4 to exit");
                input = ReadLine();
                CryptoZoo(input);
            }
            return;

        }
    }
}

