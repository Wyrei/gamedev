using System;
using System.IO;

namespace FileIOExcercise
{
    class program
    {
        public static void Main(string[] args)
        {

            DirectoryInfo dir = new DirectoryInfo(@"C:\Users\ruben\Desktop\SD1A\SD1A peroide 4\GD\FileIOExcerciseIncomplete\FileIOExcerciseIncomplete\FileIOExcercise");
            foreach(var fi in dir.GetFiles())
            {
                Console.WriteLine(fi);
            }
            

        }
    }
}