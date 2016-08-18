using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] les = { 'a','b','c'};
            char _1 = 's';
            char _2 = 'u';
            char _3 = 'c';
            char _4 = 'k';
            MainString object1 = new MainString(les, 2);
            Console.WriteLine(object1.capacity);            
            Console.WriteLine(object1.Char_index(3));
            Console.WriteLine(object1.Char_Concat());
            Console.ReadKey();

        }
    }
}