using System.IO;
using System;

namespace stringsprite
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string file = @"C:\Users\ruben\Desktop\SD1A\SD1A peroide 4\GD\stringsprite\stringsprite\stringsprite\string.txt";
            File.ReadAllText(file);
            string[] value = file.Split(',');
            int nummers = int.Parse(value[1]);
        }
    }
}
