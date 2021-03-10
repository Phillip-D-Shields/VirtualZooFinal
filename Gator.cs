using System;
using static System.Console;

namespace VirtualZooFinal
{
    class Gator : VirtualPet
    {
        // fields that only the gator have
        string LurkMethod;
        string KayakersEaten;
        string StealthRating;

        public Gator(string name, ConsoleColor color, string lurkMethod, string kayakersEaten, string stealthRating)
            : base(name, color, "imma gator")
        {

            LurkMethod = lurkMethod;
            KayakersEaten = kayakersEaten;
            StealthRating = stealthRating; 


        }

        public void DrawGator()
        {

            ForegroundColor = ConsoleColor.Green;

            WriteLine(@"
           .-._   _ _ _ _ _ _ _ _
.-''-.__.-'00  '-' ' ' ' ' ' ' ' '-.
'.___ '    .   .--_'-' '-' '-' _'-' '._
 V: V 'vv-'   '_   '.       .'  _..' '.'.
   '=.____.=_.--'   :_.__.__:_   '.   : :
           (((____.-'        '-.  /   : :
 snd                         (((-'\ .' /
                           _____..'  .'
                          '-._____.-'");

            ForegroundColor = ConsoleColor.DarkGreen;

            WriteLine($"\n{LurkMethod}");
            WriteLine($"\n{KayakersEaten}");
            WriteLine($"\n{StealthRating}");
            ForegroundColor = ConsoleColor.White;
        }

    }
}
