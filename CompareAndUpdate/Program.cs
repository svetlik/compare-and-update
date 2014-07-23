using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace CompareAndUpdate
{
    class Program
    {

        // Class to hold the files location at
        public class FilePaths
        {
            public string Old { get; set; }

            public string New { get; set; }

            public string Japanese { get; set; }

            //  File locations assignment method
            public static FilePaths ChooseLocations(FilePaths files)
            {
                Console.WriteLine("Please enter old EN files path");
                files.Old = Console.ReadLine();

                Console.WriteLine("Please enter new EN files path");
                files.New = Console.ReadLine();

                Console.WriteLine("Please enter (new) JP files path");
                files.Japanese = Console.ReadLine();

                return files;
            }
        }

        //  Method to find and get new files in a directory

        static List<object> CheckForNewFiles()
        {
            List<object> newFiles = new List<object>();

            return newFiles;
        }

        // Method to copy new files to new directory

        static void CopyFiles()
        {
            throw new NotImplementedException();
        }



        //  Method to read the file to a list to prepare it for comparison
        static List<string> ReadFile(string filePath, string fileName)
        {
            string path = filePath + "\\" + fileName;   //combining filePath + fileName
            StreamReader r = new StreamReader(path);    //

            List<string> fileAsList = new List<string>();

            return fileAsList;
         }

        static void Main(string[] args)
        {
            // an object container for the file locations
            FilePaths userInput = new FilePaths();
            FilePaths.ChooseLocations(userInput);
        }

        

        

        
    }
}
