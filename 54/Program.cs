using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _54
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>
            {
                "test",
                "test1",
                "test2"
            };

            RemoveFromList(list);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

        }

        static void RemoveFromList(List<string> list)
        {
            list.Remove("test");
        }
    }
}
