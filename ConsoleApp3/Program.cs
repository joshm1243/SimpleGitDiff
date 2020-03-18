using System;

namespace GitDiff
{
    class Program
    {
        static void Main()
        {

            bool stopProgram = false;

            //While the user does not stop the program
            while (!stopProgram)
            {

                string userInput = UI.ReadLine("> ");
                
                string[] userInputArray = userInput.Split(' ');

                if (userInputArray[0] == "diff")
                {

                    FileData file1 = FileHandler.ReadLines(userInputArray[1]);
                    FileData file2 = FileHandler.ReadLines(userInputArray[2]);

                    if (file1.Error == "" && file2.Error == "") {

                        //The files contain the sameinformation
                        if (Diff.CheckForEquality(file1, file2))
                        {
                            UI.Break();
                            Console.WriteLine("'" + file1.Name + "' and '" + file2.Name + "' are the same");
                            UI.Break();
                        }

                        //The files do not contain the same information
                        else
                        {
                            UI.Break();
                            Console.WriteLine("'" + file1.Name + "' and '" + file2.Name + "' are different");
                            UI.Break();
                        }
                    }

                    //There was an error with one of the parameters as it couldn't be opened or read
                    else
                    {
                        UI.Break();

                        if (file1.Error != "")
                        {
                            UI.WriteLine("File 1 Error: " + file1.Error);
                        }
                        
                        if (file2.Error != "")
                        {
                            UI.WriteLine("File 2 Error: " + file2.Error);
                        }

                        UI.Break();
                    }

                }

                //The user wishes to ask for help on a given function
                else if (userInputArray[0] == "help")
                {

                    //The user needs help for the 'diff' function
                    if (userInputArray[1] == "diff")
                    {
                        UI.Break();
                        UI.WriteLine("COMMAND :  'Diff' takes 2 parameters");
                        UI.WriteLine("SUMMARY :  Compares two files and returns if they're different");
                        UI.WriteLine("FORMAT  :  diff <file1> <file2>");
                        UI.Break();
                    }
                    else
                    {
                        UI.Break();
                        UI.WriteLine("Known commands:");
                        UI.WriteLine("'exit' : Closes the program");
                        UI.WriteLine("'diff' : Compares two files and returns if they're different");
                        UI.Break();
                    }
                }

                //The user wishes to exit the program
                else if (userInputArray[0] == "exit")
                {
                    UI.Break();
                    UI.Write("Press any key to exit: ");
                    stopProgram = true;
                }

                //The command could not be found
                else
                {
                    UI.Break();
                    Console.WriteLine("Unknown command '" + userInputArray[0] + "'");
                    UI.Break();
                }
            }

            Console.ReadKey();

        }
    }
}
