using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Работа_со_строками;

namespace Работа_со_строками
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] les = { 'c', 'a', 'n','a', 'l' };
            char _1 = 's';
            char _2 = 'u';
            char _3 = 'c';
            char _4 = 'k';
            char _5 = 'e';
            char _6 = 'a';
            MainString object1 = new MainString(les);
            MainString object2 = new MainString(les);
            //object2.New_string= object2.Replace('c',' ');

            //MainString object2 = new MainString('a', 4);
            // MainString object3 = new MainString();
            //Console.WriteLine(object3.New_string);

            //object3 = object1 + les;
            Console.WriteLine(object1.New_string);
            Console.WriteLine(object2.New_string);
            if (object1==object2)
                Console.WriteLine("ob1 равен ob2");
            else
                Console.WriteLine("ob1  не равен ob2");
            //Console.WriteLine(object1.New_string);
            Console.ReadKey();

        }
    }
}