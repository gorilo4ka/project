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
            int count=0;
            int position = -1;
            for (int i = 0; i < 20; i++)
            {
                list.Add(rnd.Next(0, 100));
            }
            foreach (var item in list)
            {
                if (item > 50)
                    count++;                   
                if (item % 2 == 1)
                list_even.Add(item);                
            }
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i]<16)
                {
                    position = i;
                    break;
                }
            }
            foreach (int items in list_even)
            {
                Console.WriteLine(items);
            }
            Console.WriteLine();
            foreach (int items in list)
            {
                Console.WriteLine(items);
            }
            Console.WriteLine();
            Console.WriteLine("Количество >50 - "+count);
            Console.WriteLine("позиция <16 - "+position);
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
