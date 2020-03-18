using System;
using System.Linq;

namespace GitDiff
{
    class Diff
    {

        //Checks if two array sequences are the same
        public static bool CheckForEquality(FileData file1, FileData file2)
        {
            string[] file1Content = file1.Content;
            string[] file2Content = file2.Content;
            
            return file1Content.SequenceEqual(file2Content);
        }
    }
}
