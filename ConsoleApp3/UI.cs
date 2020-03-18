using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitDiff
{
    class UI
    {
        public static void Break()
        {
            Console.WriteLine();
        }

        public static void WriteLine(string text)
        {
            Console.WriteLine(text);
        }

        public static void Write(string text)
        {
            Console.Write(text);
        } 

        public static string ReadLine(string text)
        {
            Console.Write(text);
            return Console.ReadLine();
        }
    }
}
