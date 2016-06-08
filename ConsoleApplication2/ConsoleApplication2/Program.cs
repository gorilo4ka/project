using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//sadhjasduihdui Lion
namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
           
            int[] mas1 = new int[20];
            for(int i=0;i<20;i++)
            {
                mas1[i] = rand.Next(100);
            }
            int count = 0;
            Console.WriteLine(maxInt(mas1,ref count)+" " + count);

            for (int i = 0; i < mas1.Length; i++)
            {
                Console.Write(mas1[i] + " ");
            }
            Console.ReadKey();
        }

        static int maxInt(int[] mas1, ref int count)
        {
            int max = 0;            
            int mas1_count=0;
            foreach (int x in mas1)
            {
                
                if (x > max)
                {
                    max = x;
                    mas1_count = count;
                }
                count++;

            }
            count = mas1_count;
            return max;         
        }

    }
}
