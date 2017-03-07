using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            List<int> list = new List<int>();
            List<int> list_even = new List<int>();

            for (int i = 0; i < 51; i++)
            {
                if (i == 0)
                {
                    list.Add(rnd.Next(0, 16));
                }
                list.Add(rnd.Next(0, 100));
            }

            foreach (var item in list)
            {
                if (item % 2 == 0)
                    list_even.Add(item);
            }
            foreach (int items in list_even)
            {
                Console.WriteLine(items);
            }
            foreach (int items in list_even)
            {
                if (items > 90)
                {
                    Console.WriteLine("есть больше 90");
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}
