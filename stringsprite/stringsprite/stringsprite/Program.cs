using System.IO;
using System;

namespace stringsprite
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string file = @"C:\Users\ruben\Desktop\SD1A\SD1A peroide 4\GD\stringsprite\stringsprite\stringsprite\string.txt";
            
            string text = File.ReadAllText(file);
            string[] value = text.Split(':');
            string[] nummers = (value[1].Split(','));
        }
    }
}
