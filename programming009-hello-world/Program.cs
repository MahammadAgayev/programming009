using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programming009_hello_world
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            //shortcut for runnign app: ctrl + f5

            //Console.WriteLine("Hello World");
            //Console.WriteLine("Hello World");


            //Console.WriteLine("It's a beautifull day");
            //Console.WriteLine("Hope you are doing well");
            //Console.WriteLine("This is 5th line in console");

            //Console.WriteLine("2");


            //single line comment,
            //comment shortcut: ctrl+k,c
            //uncomment shortcut: ctrl+k,u
            //This code prints out triangle.

            /*
             * multi 
             * line 
             * comment
             */

            //Console.WriteLine("*");
            //Console.WriteLine("* * ");
            //Console.WriteLine("* * *");
            //Console.WriteLine("* * * *");

            //wrong
            //Console.WriteLine(""Dədə Qorqud" dastanı");

            //escape characters -> qaçış operatorlar

            // \
            //Console.WriteLine("\"Dədə Qorqud\" dastanı");
            //Console.WriteLine("I want to print \\");
            //Console.WriteLine("\"Dədə Qorqud\" dastanı");
            //Console.WriteLine("\"Thinking Fast and Slow\" is good book and also tiring to read");

            //Console.WriteLine("'Thinking Fast and Slow' is good book and also tiring to read");
            //Console.WriteLine("\'Thinking Fast and Slow\' is good book and also tiring to read");


            //Console.Write("\"Dədə Qorqud\" dastanı\n");
            //Console.Write("I want to print \\\n");
            //Console.Write("\"Dədə Qorqud\" dastanı\n");
            //Console.Write("\"Thinking Fast and Slow\" is good book and also tiring to read\n");

            //Console.WriteLine("It's \t tab");

            //Console.Write("It's a simple sentence for test\n\t");
            //Console.WriteLine("Second sentence");

            //Console.Beep(300, 1000);

            //Console.Write("Test  test");
            //Console.Write("\r");
            //Console.WriteLine("Test2 nothing after this");


            //Console.Write("We are learning c#");
            //Console.Write("\r");
            //Console.WriteLine("They--------------------");
            //Console.WriteLine("They------------");

            //DO NOT DO THIS
            //Console.WriteLine("Mahammad");


            //simple version
            //Console.WriteLine("*       *");
            //Console.WriteLine("* *   * *");
            //Console.WriteLine("*   *   *");
            //Console.WriteLine("*       *");
            //Console.WriteLine("*       *");

            //harder version, do this with \n and \t in one line without multiple Console.WriteLine

            //Console.ReadLine();
            //Console.ReadKey();

            //Console.WriteLine("*      *\n* *  * *\n*   *  *\n*      *\n*      *");

            //Console.WriteLine(1 + 2);
            //Console.WriteLine(2 + 3);
            //Console.WriteLine(6 / 2);
            //Console.WriteLine(6 * 2);

            //not wrong but hard to read
            //Console.Write("1 + 2 = ");
            //Console.WriteLine(1 + 2);

            //Console.WriteLine("1 + 2 = " + (1 + 2));
            //// "1 + 2 = 1" + 2
            //// "1 + 2 = 12"

            ////Console.WriteLine("Hello " + "World");

            //Console.WriteLine(3 + 4);
            //mətn tipli məlumat string adlanır

            //Console.WriteLine("1 + 2 = " + (1 + 2));
            Console.WriteLine("1 + 2 = " + (1 + 2) + ", 3 + 4 = " + (3 + 4));
            //string formatting
            Console.WriteLine("1 + 2 = {0}, 3 + 4 = {1}", 1 + 2, 3 + 4);

            //string interpolation
            Console.WriteLine($"1 + 2 = {1 + 2}, 3 + 4 = {3 + 4}");

            //print out in different languages
            //Console.WriteLine("test);
            //cout << "test" << endl;
            //print
            //println
            //printf
            //system.out.println
            //println!("test")
                           //      12   +   8 + 1 = 9  => 129
            Console.WriteLine(1 + "" + 2 + ( (5 + 3) + 1 ) );
            //out: 129

            Console.WriteLine(1 + "" + 2 +(5 + 3) + 1);
            //out: 1281
        }
    }
}