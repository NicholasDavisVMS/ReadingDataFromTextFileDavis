using System;
using System.IO;

namespace ReadingDataFromTextFileDavis
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Solution Explorer>Add>New Item>Scroll Down to 'Text File'.
            //HELP! CAN'T FIND SOLUTION EXPLORER MENU FOR ADD!!! Actually: do new file!!!
            //You get a new tab when you do this

            //Note: one issues is that while Values.txt is in solution explorer, 
            //but it's not in the project's bin.Debug directory
            //Go to solution explorer, go to Values.txt, allow 'Copy to Output directory' to copy
            //WHERE IS PROJECT MANAGER????
            //HOW TO I GET VALUES.TXT TO THE PROJECT'S BIN???

            //Note: StreamReader will not run by itself, as it doesn't live in default namespaces in project
            //It uses System.IO
            //StreamReader is used to open file, like a 'straw', and put the Values file into 'myReader'
            //Mac's do not seem to have an automatic arrow when scrolling over StreamReader to help resolve
            //the issue
            //Multiple ways to fix red squiglly line(above and below) but doesn't fix 2nd part of function
            //Note: needs 'System.IO'
            System.IO.StreamReader myReader = new System.IO.StreamReader("Values.txt");
            string line = "";
            //Just an empty string

            //Iterate through codeblock unless not equal to null(unkown or indeterminate). 
            //Run until End of file then it will be equal to 'null'
            //NOTE: the 'while' statement will continue to run until it is 'false'
            //'while' is used to run through an ideterminate number of code, unlike
            //for statements where it has a limited number
            while (line != null)
            {
                line = myReader.ReadLine();
                if (line != null)
                {
                    Console.WriteLine(line);
                }
            }


            //The .Close(); closes all ties to outside files. In this case it is 'Values.txt'
            myReader.Close();
            Console.ReadLine();
            //If nothing else you learned how to add an additional file to a project?
        }
    }
}
