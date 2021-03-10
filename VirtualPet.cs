using System;
using static System.Console;

namespace VirtualZooFinal
{
    class VirtualPet
    {
        string Name;
        string Type;

        ConsoleColor Color;

        public VirtualPet(string name, ConsoleColor color, string type)
        {
            Name = name;
            Color = color;
            Type = type;
        }

        public VirtualPet()
        {
        }

        public void Greet()
        {
            ForegroundColor = Color;
            WriteLine($"\n{Name}");
            WriteLine($"{Type}");

            ResetColor();
        }

        public void Draw()
        {
            ForegroundColor = Color;
            WriteLine(@"
   __                       __
 __\_\___               ___/_/__
/_______ \___       ___/\_______\
   \_\  \/__/\_____/\__\/  /_/
            \/_____\/                      __
             \o | o/_____ ________________/\_\
              \ | /_______\_______________\/
               \_/        /               |
                         /\           _   |
                        / /\_________/ |__|
                       / /             / /
                      /_/             /_/
                      \ \             \ \
                       \ \             \_\
                        \_\            /_/
                        /_/            |_|");
        }

    }
}
