/*************************************************************************************************************************
Author: Madison Dunning
Date: 11/31/16
OS: Windows 10
Purpose: Your company's users create or edit a collection of text files
         throughout the day. These text files represent data about customer
         orders.
         Once per day, any files that are new, or that were edited within the
         previous 24 hours, must be sent to the home office. To facilitate this,
         these new or updated files need to be copied to a specific 'destination'
         folder on a computer, so that a special file transfer program can grab
         them and transfer them to the home office.
         The process of figuring out which files are new or recently edited, and
         copying them to the 'destination' folder, is currently being done
         manually. This is very expensive in terms of manpower.
         You have been asked to create a script that will automate this task,
         saving the company a lot of money over the long term.
  
**************************************************************************************************************************/﻿

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileTransfer
{
    class Program
    {
        private static string targetPath;
        public static bool running;

        static void Main(string[] args)
        {
            var function = new Functions();
            running = true;
            int num = 0;

            while (running)
            {

                Console.WriteLine("New files in Customer Orders: ");
                ModifiedFiles newFiles = new ModifiedFiles();
                num = 0;

                foreach (var file in newFiles.modified())
                {
                    Console.WriteLine("\"" + file + "\"");
                    num++;
                }

                Console.WriteLine("Would you like to transfer {0} file(s) to Home Office? y/n", num);
                string answer = Console.ReadLine();

                if (answer == "y")
                {
                    targetPath = @"C:\Users\Dunning\Desktop\Home Office";

                    num = 0;
                    foreach (var file in newFiles.modified())
                    {
                        File.Copy(file.FullName, Path.Combine(targetPath, file.Name), true);
                        num++;
                    }

                    Console.WriteLine("{0} file(s) transfered.", num);
                    function.exit();
                }

                else if (answer == "n")
                {
                    function.exit();
                }

                else
                {
                    function.wrong();
                }
            }
        }
    }
    class ModifiedFiles
    {
        public string sourceDir;
        public IEnumerable<FileInfo> modified()
        {
            sourceDir = @"C:\Users\Dunning\Desktop\Destination";
            var directory = new DirectoryInfo(sourceDir);
            DateTime from_date = DateTime.Now.AddDays(-1);
            DateTime to_date = DateTime.Now;
            var files = directory.GetFiles()
              .Where(file => file.LastWriteTime >= from_date && file.LastWriteTime <= to_date);
            return files.ToList();
        }
    }
    class Functions
    {
        public void wrong() { Console.WriteLine("Your answer must be in the form: 'y' or 'n'."); }

        public void exit()
        {
            Console.WriteLine("Have you completed your file transfer? y/n");
            string answerExit = Console.ReadLine();
            if (answerExit == "y")
            {
                Console.WriteLine("Thank You.");
                Environment.Exit(0);
            }
            else if (answerExit == "n")
            {
                // Loop back to beginning
            }
            else
            {
                this.wrong();
            }

        }
    }
}
