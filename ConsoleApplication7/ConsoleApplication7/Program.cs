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
            MainString object1 = new MainString('l', 2);
            String str = new String(les, 0, 3);
            //Console.WriteLine(str.Length);
            //Console.WriteLine(object1.Length);            
            //Console.WriteLine(object1.Char_index(3));
            Console.WriteLine(object1.Char_Concat(les));
            Console.ReadKey();

        }
    }
}