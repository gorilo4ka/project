using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Перегрузка
{
    class Program
    {
        class ThreeD
        {
            int x, y, z; // 3-х-мерные координаты.
            public ThreeD()
            {
                x = y = z = 0;
            }
            public ThreeD(int i, int j, int k)
            {
                x = i;
                y = j;
                z = k;
            }
            // Перегрузка бинарного оператора "+".
            /*public static ThreeD operator +(ThreeD op1,
            ThreeD op2)
            {
                ThreeD result = new ThreeD();
                /* Суммирование координат двух точек
                и возврат результата. 
                result.x = op1.x + op2.x; // Эти операторы выполняют
                result.y = op1.y + op2.y; // целочисленное сложение.
                result.z = op1.z + op2.z;
                return result;
            }*/
            public void show()
            {
                Console.WriteLine(x + ", " + y + ", " + z);
            }
        }

            static void Main(string[] args)
        {
            ThreeD a = new ThreeD(1, 2, 3);
            ThreeD b = new ThreeD(10, 10, 10);
            ThreeD c = new ThreeD();
            c = a + b;
            c.show();
            Console.ReadKey();
        }
    }
}
