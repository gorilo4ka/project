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
            char[] les = { 'd', 'e', 'r','k' };
            char _1 = 's';
            char _2 = 'u';
            char _3 = 'c';
            char _4 = 'k';
            char _5 = 'e';
            MainString object1 = new MainString(les);
            //MainString object2 = new MainString('a', 4);
            //MainString object3 = new MainString(les, 0, 4);
            //Console.WriteLine(object3.New_string);

          
            Console.WriteLine(object1.System_CAPS_pubmethod(_4,0));

            //Console.WriteLine(object3.New_string);
            Console.ReadKey();

        }
    }
}