using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _53
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //compile time
            const double pi = 3.14;
           

            //const
            /* defined in compile time (kod icra edilməmişdən əvvəl təyin edilir)
             * Guarantees no change (verilən məlumatın heç vaxt dəyişməyəcəyin qaranti edir)
             */

            //runtime time
            double val = double.Parse(Console.ReadLine());

            Test();
            Test();

            Console.WriteLine(pi * val);
        }

        static void Test()
        {
            double t = 10; //8 byte
            const double t1 = 10; //8 byte kod icra olunmağa başlayanda ayrılır
        
        }
        //t: 8 byte goes back to memory
        //t1: 8 byte nerver returns to memory until program dies
    }
}
