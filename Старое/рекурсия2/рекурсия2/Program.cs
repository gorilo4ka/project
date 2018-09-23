using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Рекурсия2
{
    class Program
    {
        class rekursia
        {
            public void ABC(int A,int B)
            {

                if (A < B)
                {
                    if (A > B)
                        return;
                    Console.WriteLine(A);
                    ABC(A +1, B);
                }
                 if (A>B)
                {
                    if (A < B)                   
                        return;
                    Console.WriteLine(A);
                    ABC(A-1, B);
                }
                if (A==B)
                {
                    Console.WriteLine(B);
                }             
            }
         

        }
        static void Main(string[] args)
        {
            rekursia AB = new rekursia();
            AB.ABC(33,19);
            Console.ReadKey();
        }
    }
}
