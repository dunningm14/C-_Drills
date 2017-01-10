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
