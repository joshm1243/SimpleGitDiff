using System;
using System.IO;

namespace GitDiff
{

    class FileHandler
    {
        //Translates a relative file path into an absolute file path
        private static string GetAbsolutePath(string path)
        {
            if (Path.IsPathRooted(path))
            {
                return path;
            }
            else
            {

                //Returns the absolute path of a path specified
                return Path.GetFullPath(path);
            }
        }

        //Checks if a file exists at the filepath given
        private static bool Exists(string path)
        {
            if (File.Exists(path)) { return true; }
            else { return false; }
        }

        //Reads a file and returns an array containing each line as a string
        public static FileData ReadLines(string path)
        {

            FileData file = new FileData();
 
            string absolutePath = GetAbsolutePath(path);

            //Creating the name
            file.Name = absolutePath.Split('\\')[absolutePath.Split('\\').Length - 1];

            //If the file does exist
            if (Exists(absolutePath))
            {
                try
                {
                    //Attempt to read all the lines of the file
                    file.Content = File.ReadAllLines(absolutePath);
                }

                //The absolute filepath entered by the user was too long to trace
                catch (PathTooLongException)
                {
                    file.Error = "A filepath entered was too long.";
                }

                //The file could not be opened due to an I/O error
                catch (IOException)
                {
                    file.Error = "An I/O error occurred while attempting to open the file.";
                }
            }

            //If the file does not exist
            else
            {
                file.Error = "The file specified does not exist.";
            }

            return file;
        }
    }
}
