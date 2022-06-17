using System;

namespace EnumOpdracht
{
    class Program
    {
        static void Main(string[] args)
        {
            colors achtergrondkleur = colors.red;
            if (achtergrondkleur == colors.green)
            {
                Console.BackgroundColor = ConsoleColor.Green;
            }
        }
        enum colors
        {
            red,
            green,
            blue,
            yellow
        }
           

        
    }
}
