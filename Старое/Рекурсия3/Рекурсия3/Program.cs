using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Рекурсия3
{
    class Program
    {
        class Rekursia
        {
            public void Answ(int N)
            {
                if(N%2!=0&N!=1)
                {
                    //Console.WriteLine("");
                    return;
                }
                if (N / 2 == 1 | N == 1)
                {
                    Console.WriteLine("YES" + N);
                    return;
                }
                Answ(N / 2);
            }
        }
        static void Main(string[] args)
        {
            Rekursia rekurs = new Rekursia();
            for (int i = 33; i >0; i--)
            {
                rekurs.Answ(i);
            }
            
            Console.ReadKey();
        }
    }
}
