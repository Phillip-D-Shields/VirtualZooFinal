using System;
using static System.Console;

namespace VirtualZooFinal
{
    class Leopard : VirtualPet
    {
        // fields that only the gator have
        string LoungeLocal;
        string MonkeysEaten;
        string LongestSleep;

        public Leopard(string name, ConsoleColor color, string loungeLocal, string monkeysEaten, string longestSleep)
            : base(name, color, "the lavish leopard")
        {
            LoungeLocal = loungeLocal;
            MonkeysEaten = monkeysEaten;
            LongestSleep = longestSleep;
        }

        public void DrawLeopard()
        {
            ForegroundColor = ConsoleColor.Magenta;

            WriteLine(@"  
            _      _
           (c\-.--/a)
            |q: p   /\_            _____
          __\(_/  ).'  '---._.---'`     '---.__
         /  (Y_)_/             /        : \-._ \
 !!!!,,, \_))'-';             (       _/   \  '\\_
!!II!!!!!IIII,, \_             \     /      \_  '.\
 !IIsndIIIII!!!!,,\     /_      \   |----.___ '-. \'.__
 !!!IIIIIIIIIIIIIIII\   | '--._.-'  _)       \  |  `'--'
     '''!!!!IIIIIII/   .',, ((___.-'         / /
           '''!!!!/  _/!!!!IIIIIII!!!!!,,,,,;,;,,,.....
                 | /IIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII
                 | \   ''IIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII
                 \_,)     '''''!!!!IIIIIIIIIIIIIIII!!!!!!!!
                                   ''''''''''!!!!!!!!!!!!!!!");
            ForegroundColor = ConsoleColor.DarkMagenta;

            WriteLine($"\n{LoungeLocal}");
            WriteLine($"\n{MonkeysEaten}");
            WriteLine($"\n{LongestSleep}");
            ForegroundColor = ConsoleColor.White;
        }
    }
}
