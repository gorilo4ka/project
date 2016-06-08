using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//456465

namespace ConsoleApplication3
{
    class Program
    {

        static bool Check_X(int x)
        {
            if (x == 1 || x == 2 || x == 3)
            {
                return true;
            }
            return false;
        }

        static void prnt(string[,] square )
        {
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    Console.Write(square[i, j]);
                }
                Console.WriteLine();
            }
        }

        static void Input(string[,] square)
        {
            Console.WriteLine("Введите координаты X(от 1 до 3)");
            int Coord_X = -1;
            bool isNumber = Int32.TryParse(Console.ReadLine(), out Coord_X);
            while (!isNumber || !Check_X(Coord_X))
            {
                Console.WriteLine("Error");
                Console.WriteLine("Введите координаты X(от 1 до 3)");
                isNumber = Int32.TryParse(Console.ReadLine(), out Coord_X);
            }

            Console.WriteLine("Введите координаты Y(от 1 до 3)");
            int Coord_Y = -1;
            isNumber = Int32.TryParse(Console.ReadLine(), out Coord_Y);
            while (!isNumber || !Check_X(Coord_Y))
            {
                Console.WriteLine("Error");
                Console.WriteLine("Введите координаты Y(от 1 до 3)");
                isNumber = Int32.TryParse(Console.ReadLine(), out Coord_Y);
            }
            Coord_X = Coord_X * 2 - 2;
            Coord_Y = Coord_Y * 2 - 2;
            square[Coord_X, Coord_Y] = "X";
            prnt(square);
        }          

        
        static void Main(string[] args)
        {
            string[,] square = new string[6, 6];
            for (int i = 0; i < 5; i++)
                {
                    for (int j = 1; j < 5; j = j + 2)
                    {
                        square[i, j] = "|";
                    }
                }
                for (int i = 1; i < 5; i = i + 2)
                {
                    for (int j = 0; j < 5; j = j + 2)
                    {
                        square[i, j] = "-";
                    }
                }


           

            square[0, 0] = " ";
            square[0, 2] = " ";
            square[0, 4] = " ";
            square[2, 0] = " ";
            square[2, 2] = " ";
            square[2, 4] = " ";
            square[4, 0] = " ";
            square[4, 2] = " ";
            square[4, 4] = " ";
            square[5, 0] = "1";
            square[5, 2] = " 2";
            square[5, 4] = " 3";
            square[0, 5] = " 1";
            square[2, 5] = " 2";
            square[4, 5] = " 3";

            Input(square);
            Input(square);
            Input(square);
            Input(square);
            Input(square);

            
            Console.ReadKey();
        }
       
    }
}
