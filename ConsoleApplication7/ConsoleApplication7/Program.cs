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
            char[] les = { 'd','e','r'};
            char _1 = 's';
            char _2 = 'u';
            char _3 = 'c';
            char _4 = 'k';
            // MainString object1 = new MainString('s', 2);
            //MainString object2 = new MainString('a', 4);
            //MainString object3 = new MainString(les, 0, 4);
            //Console.WriteLine(object3.New_string);

            MainString object1 = new MainString(les);
            Console.WriteLine(object1.New_string);
            les[0] =  'w' ;
            Console.WriteLine(object1.New_string);
            //Console.WriteLine(object1.Char_index(3));

            //Console.WriteLine(object3.New_string);
            Console.ReadKey();

        }
    }
}