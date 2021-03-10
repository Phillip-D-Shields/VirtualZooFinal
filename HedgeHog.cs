using System;
using static System.Console;

namespace VirtualZooFinal
{
    class HedgeHog : VirtualPet
    {
        // fields that only the hedgehog have
        string Scurritude;
        string Height;
        string SecretAbility;

        public HedgeHog(string name, ConsoleColor color, string scurritude, string height, string secretAbility)
            : base(name, color, "we is hedgehog")
        {
            Scurritude = scurritude;
            Height = height;
            SecretAbility = secretAbility;

        }
        public void DrawHedgeHog()
        {
            ForegroundColor = ConsoleColor.Red;
            WriteLine(@"
  .::::::::..          ..::::::::.
 :::::::::::::        :::::::::::::
:::::::::::' .\      /. `:::::::::::
`::::::::::_,__o    o__,_::::::::::'");

            ForegroundColor = ConsoleColor.DarkRed;

            WriteLine($"\n{Scurritude}");
            WriteLine($"\n{Height}");
            WriteLine($"\n{SecretAbility}");
            ForegroundColor = ConsoleColor.White;
        }
       
    }
}
