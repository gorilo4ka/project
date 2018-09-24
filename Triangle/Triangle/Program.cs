using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            Console.WriteLine($"Введите область треугольника\n1|2\n3|4");
            string s = Console.ReadLine();
            Int32.TryParse(s, out x);
            Triangle(x);            
            Console.ReadKey();
        }

        public static void Prnt(string [,] a)
        {
            for (int i = 0; i < a.GetLength(1); i++)
            {
                for (int j = 0; j < a.GetLength(0); j++)
                {
                    Console.Write(a[i, j]);
                }
                if (true)
                {

                }
                Console.WriteLine();
            }
        }
        public static string[,] Triangle(int a)
        {
            string [,] Tri = new string[6, 6];
            for (int i = 0; i < Tri.GetLength(1); i++)
            {
                
                for (int j = 0; j < Tri.GetLength(1); j++)
                {
                    
                    Tri[i, j] = " ";
                }
            }
            switch (a)
            {
                case 1:
                    for (int i = 0; i < Tri.GetLength(1); i++)
                    {
                       
                        for (int j = Tri.GetLength(1)-1; j >=Tri.GetLength(0)-i-1; j--)
                        {                            
                            Tri[i, j] = "-";
                        }
                    }

                    Prnt(Tri);
                    break;
              case 2:
                    for (int i = 0; i < Tri.GetLength(1); i++)
                    {
                        for (int j = i; j < Tri.GetLength(0); j++)
                        {
                            Tri[j, i] = "-";
                        }
                    }
                    Prnt(Tri);
                    break;
                case 3:
                    for (int i = 0; i < Tri.GetLength(1); i++)
                    {
                        for (int j = i; j < Tri.GetLength(0); j++)
                        {
                            Tri[i, j] = "-";
                        }
                    }
                    Prnt(Tri);
                    break;
                case 4:
                    for (int i = 0; i < Tri.GetLength(1); i++)
                    {
                        for (int j =0; j < Tri.GetLength(0)-i;j++ )
                        {
                            Tri[i, j] = "-";
                        }
                    }
                    Prnt(Tri);
                    break;

                default:
                    Console.WriteLine("Неверный ввод");
                    break;
            }
            return Tri;
        }
    }
}
