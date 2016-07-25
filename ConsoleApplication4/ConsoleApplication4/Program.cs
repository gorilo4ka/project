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
            char ch = 'a';
            char ch1 = 'b';
            ch = (char) (ch + ch1*2);
            Console.WriteLine(ch);
            Console.ReadKey();

        }
    }
}
