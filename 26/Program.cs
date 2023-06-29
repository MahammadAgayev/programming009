using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 2 3 4 5 6
            //1 2 4 5 6 0

            //1 2 3 4 5 6
            //1 2 6 4 5 


            /*
             *  9, 0, 3, 4, 5, 6, 7, 8
             */

            //Binary Tree

            /*
             * depth of the tree
             *         (5)
             *        /     \   
             *      (2)       (8)
             *     /    \     /  \
             *  (1)      (4) (6) (10)
             *        /             \
             *       (3)           (12)
             *                     /  \
             *                   (11) (16)
             *                         /
             *                      (13)
             */

            //6 + (1-5) => 21
            //5 + (1-4) => 15
            //4 + (1-3) => 10
            //3 + (1-2) => 6
            //2 + (1-0) => 3
            //1 + (0) => 1

            int sum = SumRecurse(5);

            Console.WriteLine(sum);
        }

        static int SumRecurse(int n)
        {
            if (n == 0) return 0;

            return  n + SumRecurse(n - 1);
        }
    }
}
