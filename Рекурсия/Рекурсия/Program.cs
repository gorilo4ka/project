using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Рекурсия1
{
    class Program
    {
        class Rekursia
        {
            
            public void print(int n,int m)
            {
            Console.WriteLine(m);
                if (m==n)
                {                                        
                    return;
                }                
                print(n,m+1);    
            }
        }
        static void Main(string[] args)
        {
            Rekursia f = new Rekursia();
            f.print(15,1);
            Console.ReadKey();
        }
    }
}
