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
            int count_5;
            int count_15;
            Console.Write("Больше 5 - ");
            Console.WriteLine(count_5 = list.Count(x => x > 5));
            Console.Write("Меньше 15 - ");
            Console.WriteLine( count_15 = list.Count(x => x < 15));
            Console.Write("Больше 5 и Меньше 15 - "); 
            Console.WriteLine(count_15 = list.Count(x => x < 15&&x>5));
            List<string> list_ = new List<string> { "one", "two", "three", "four", "five" };
            int count_4 = (list_.Count(i => i.Length == 4));          
           
            Console.WriteLine(list_.FirstOrDefault(i=>i.Length==3)+" первое");
            Console.WriteLine(list_.LastOrDefault(i => i.Length == 3) + " последнее");
            List<string> list_t = list_.Where(i => i.StartsWith("t")).ToList();
            foreach (var item in list_t)
            {
                Console.WriteLine(item);
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
