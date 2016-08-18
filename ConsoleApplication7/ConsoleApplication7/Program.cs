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
            MainString object1 = new MainString('s', 2);
            MainString object2 = new MainString('a', 4);
            MainString object3 = object1.Class_Concat(object2);
            String str = new String(les, 0, 3);
            //Console.WriteLine(str.Length);
            //Console.WriteLine(object1.Length);            
            //Console.WriteLine(object1.Char_index(3));
            
            Console.WriteLine(object3.new_string);
            Console.ReadKey();

        }
    }
}