using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDick
{
    class Program
    {
        public void Main(string[] args)
        {
             Dictionary<int, string> My_dick = new Dictionary<int, string>(5)
            {
                [1] = "one",
                [2] = "two",
                [3] = "four",
                [4] = "five"
            };
            Dictionary<string, int> My_dick_is_big = new Dictionary<string, int>(5)
            {
            };
            
            foreach (var items in My_dick)
            {
                My_dick_is_big.Add(items.Value,items.Key);
            }
            if(My_dick.ContainsKey(4))
            {
                Console.WriteLine(My_dick[4]);
            }
            if(My_dick_is_big.ContainsKey("four"))
            {
                Console.WriteLine(My_dick_is_big["four"]);
            }

            foreach (var item in My_dick_is_big)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(My_dick.Any(i=>i.Value.Length==3));
            Console.WriteLine(My_dick_is_big.FirstOrDefault(i=>i.Key.Length==3));
            Console.ReadKey();
        }
    }
}
