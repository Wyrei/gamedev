using System;
using System.IO;

namespace FileDirOpdracht
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = new string[1] ("aangenaam", "werkt het");
            string file = @"C:\Users\ruben\Desktop\SD1A\SD1A peroide 4\GD\FileDirOpdracht\FileDirOpdracht\text,txt";
            File.WriteAllLines(file, text);

            string[] gelezen = File.ReadAllLines(file);
            foreach (string txt in text)
            {
                Console.WriteLine(txt);
            }


        }
    }
}
