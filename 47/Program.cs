using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.DesignerServices;
using System.Text;
using System.Threading.Tasks;

namespace _47
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //System IO -> input, output
            //Disk IO

            //keçici yaddaş, sərt disk
            //output
            //Console.WriteLine("Hello World");

            ////input
            //Console.ReadLine();

            //const string path = @"c:\tmp\data.txt";
            //File
            //Directory

            //File.Create(@"c:\tmp\test.txt");

            //string text = Console.ReadLine();

            //File.WriteAllText(@"c:\tmp\data.txt", text);

            //string text = File.ReadAllText(path);

            //Console.WriteLine(text);


            //File.WriteAllText(path, "Hello from write all text");
            //File.AppendAllText(path, "\n\tSecond line from text");

            //string[] words = { "Hello", "Hell", "What" };

            //File.AppendAllLines(path, words);

            //File.Copy(path, @"c:\tmp\path2");

            //File.Move(@"c:\tmp\path2", @"c:\tmp\data2.txt");

            //File.Delete(path);

            //persistent operation

            //if (File.Exists(path))
            //{
            //    Console.WriteLine($"{path} already exists");
            //}
            //else
            //{
            //    Console.WriteLine($"{path} not exists, creating....");

            //    File.Create(path);
            ////}

            //const string dir = @"c:\tmp\data";


            //if (Directory.Exists(dir))
            //{
            //    Console.WriteLine("Directory exists, ignoring...");
            //}
            //else
            //{

            //    Console.WriteLine("Creating directory...");
            //    Directory.CreateDirectory(dir);
            //}

            //Console.WriteLine("Directory created");

            //if (File.Exists(@"c:\tmp\data\hello.csv") == false)
            //{
            //    File.WriteAllText(@"c:\tmp\data\hello.csv", "Hello World");
            //}

            //Directory.Delete(@"c:\tmp\data", recursive: true);




            //Console.WriteLine("Done.");

            //const string dir = @"c:\tmp\data";
            //Directory.CreateDirectory(dir);

            // c:\tmp\data\hello.txt
            // this is rename
            // c:\tmp\data2\hello.txt

            // c:\tmp\data\hello.txt
            // move = copy -> delete
            // d:\tmp\data\hello.txt


            //Console.WriteLine("Please enter appname: ");
            //string appname = Console.ReadLine();

            //string path = $@"C:\tmp\{appname}\";

            //Directory.CreateDirectory(path);

            ////copy all data to 
            //File.Copy("47.exe", path + "47.exe");

            //uninstall

            //relative path
            //absolute path

            /*
             *  /  -> root directory
             *  .  -> current directory
             *  ~  -> home directory
             *  .. -> back directory
             */

            //Console.Write("Input source path: ");
            //string source = Console.ReadLine();

            //Console.Write("Input destination path: ");
            //string destination = Console.ReadLine();

            //File.Copy(source, destination);

            //FileInfo info = new FileInfo(source);

            //FileStream stream = File.Open(source, FileMode.Open);
            //StreamReader reader = new StreamReader(stream);
            //StreamWriter writer = File.AppendText(destination);

            //EOF end of stream

            //double totalCopied = 0;
            //while(reader.EndOfStream == false)
            //{
            //    char[] buffer = new char[4096];

            //    int read = reader.ReadBlock(buffer, 0, buffer.Length);

            //    writer.Write(buffer, 0, read);
            //    totalCopied += read;

            //    double result = (totalCopied / info.Length) * 100;

            //    result = Math.Round(result, 2);

            //    Console.Write($"\r{result}");
            //}

            //Console.WriteLine("done");

            //200kb 4kb = 196kb  (4 / 200) * 100 = 2%/


            using (FileStream stream = File.Open(@"c:\tmp\test", FileMode.Open))
            {


                stream.Dispose();
            }

            //StreamWriter
            //StreamReader
        }
    }
}
