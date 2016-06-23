using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        enum Days : long
        {

        }
        static void Main(string[] args) {
            char[][] multiArray = new char[][] { new char[] { 'a', 'b', 'c' }, new char[] { 'b', 'c' } };
            Console.WriteLine(multiArray[0].Length);
            Console.ReadLine();
        }
    }
}
