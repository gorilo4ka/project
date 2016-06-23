using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {

        static bool Check_WinX(string[,] square)
        {
            if (square[2, 2] == "X")
            {
                if (square[2, 0] == "X" && square[2, 4] == "X")
                    return true;

                else if (square[0, 2] == "X" && square[4, 2] == "X")
                    return true;

                else if (square[0, 0] == "X" && square[4, 4] == "X")
                    return true;

                else if (square[0, 4] == "X" && square[4, 0] == "X")
                    return true;
            }

            //боковые 
            else if (square[0, 2] == "X" && square[0, 0] == "X" && square[0, 4] == "X")
            {
                return true;
            }

            else if (square[2, 0] == "X" && square[0, 0] == "X" && square[4, 0] == "X")
            {
                return true;
            }

            else if (square[4, 2] == "X" && square[4, 0] == "X" && square[4, 4] == "X")
            {
                return true;
            }

            else if (square[2, 4] == "X" && square[0, 4] == "X" && square[4, 4] == "X")
            {
                return true;
            }
            
            
            return false;
              
        }


        static bool Check_WinO(string[,] square)
        {
            if (square[2, 2] == "O")
            {
                if (square[2, 0] == "O" && square[2, 4] == "O")
                    return true;

                else if (square[0, 2] == "O" && square[4, 2] == "O")
                    return true;

                else if (square[0, 0] == "O" && square[4, 4] == "O")
                    return true;

                else if (square[0, 4] == "O" && square[4, 0] == "O")
                    return true;
            }

            //боковые 
            else if (square[0, 2] == "O" && square[0, 0] == "O" && square[0, 4] == "O")
            {
                return true;
            }

            else if (square[2, 0] == "O" && square[0, 0] == "O" && square[4, 0] == "O")
            {
                return true;
            }

            else if (square[4, 2] == "O" && square[4, 0] == "O" && square[4, 4] == "O")
            {
                return true;
            }

            else if (square[2, 4] == "O" && square[0, 4] == "O" && square[4, 4] == "O")
            {
                return true;
            }
            
            return false;
        }


        static bool Check_X(string [,] square,int x)
        {
            for (int i = 1; i <= square.GetLength(0) / 2; i++)
            {
                if (x == i)
                {
                    return true;
                }
            }

            return false;
        }

        static bool Check_PlaceX(string[,] square,int x, int y)
        {
            if (square[x,y]=="O")
            {
                return true;
            }
            return false;
        }

        static bool Check_PlaceY(string[,] square, int x, int y)
        {
            if (square[x, y] == "X")
            {
                return true;
            }
            return false;
        }



        static void Input(string[,] square)
        {
            int Coord_X = -1; int Coord_Y = -1;
            
            while (true)
            {

                Console.WriteLine("Введите координаты X(от 1 до "+square.GetLength(0)/2+")");
                bool isNumber = Int32.TryParse(Console.ReadLine(), out Coord_X);
                while (!isNumber || !Check_X(square,Coord_X))
                {
                    Console.WriteLine("Error");
                    Console.WriteLine("Введите координаты X(от 1 до "+square.GetLength(0)/2 + ")");
                    isNumber = Int32.TryParse(Console.ReadLine(), out Coord_X);
                }

                Console.WriteLine("Введите координаты Y(от 1 до " + square.GetLength(0) / 2 + ")");
                isNumber = Int32.TryParse(Console.ReadLine(), out Coord_Y);
                while (!isNumber || !Check_X(square,Coord_Y))
                {
                    Console.WriteLine("Error");
                    Console.WriteLine("Введите координаты Y(от 1 до " + square.GetLength(0) / 2 + ")");
                    isNumber = Int32.TryParse(Console.ReadLine(), out Coord_Y);
                }
                Coord_X = Coord_X * 2 - 2;
                Coord_Y = Coord_Y * 2 - 2;

                if (Check_PlaceX(square, Coord_X, Coord_Y) || Check_PlaceY(square, Coord_X, Coord_Y))
                {
                    Console.WriteLine("В данном месте находится символ противника");

                }
                else
                    break;
            }

            square[Coord_X, Coord_Y] = "X";
            prnt(square);

        }

        static void Turn_Bot(string[,] square)
        {
            int Coord_X = -1; int Coord_Y = -1;
            while (true)
            {
                Random rnd = new Random();
                 Coord_X = rnd.Next(1, square.GetLength(0)/2+1);
                 Coord_Y = rnd.Next(1, square.GetLength(0)/2+1);
                Coord_X = Coord_X * 2 - 2;
                Coord_Y = Coord_Y * 2 - 2;
                if (!(Check_PlaceY(square, Coord_X, Coord_Y) || Check_PlaceX(square, Coord_X, Coord_Y)))
                {
                    break;
                }
            }
            square[Coord_X, Coord_Y] = "O";
            prnt(square);
        }

        static void prnt(string[,] square)
        {
            Console.WriteLine();
            for (int i = 0; i < square.GetLength(0); i++)
            {
                for (int j = 0; j < square.GetLength(0); j++)
                {
                    Console.Write(square[i, j]);
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            int LengX = 0;
            Console.WriteLine("Введите размер поля");
            bool isNumber = Int32.TryParse(Console.ReadLine(), out LengX);
            while (!isNumber || LengX<3)
            {
                Console.WriteLine("Error");
                Console.WriteLine("Введите размер поля");
                isNumber = Int32.TryParse(Console.ReadLine(), out LengX);
            }
            LengX = LengX * 2+1;
            string[,] square = new string[LengX, LengX];
            for (int i = 0; i < LengX-2; i++)
                {
                    for (int j = 1; j < LengX-1; j = j + 2)
                    {
                        square[i, j] = "|";
                    }
                }
                for (int i = 1; i < LengX-2; i = i + 2)
                {
                    for (int j = 0; j < LengX-2; j = j + 2)
                    {
                        square[i, j] = "-";
                    }
                }



            for (int i = 0; i < LengX-2; i=i+2)
            {
                for (int j = 0; j < LengX-2; j=j+2)
                {
                    square[i,j] = " ";
                }
                int z = 1 + i / 2;
                String number = Convert.ToString(z);
                square[LengX - 1, i] =  number+" ";
                square[i, LengX - 1] = " " + number;
            }
            
            int text=5;
            do
            {
                if(Check_WinO(square))
                {
                    text = 1;
                    break;
                }
                Input(square);
                Turn_Bot(square);
            }
            while (!Check_WinX(square));
            if(text==1)            
                Console.WriteLine("Ты кот");
            else            
            Console.WriteLine("Тебе удалось это аутист");
            Console.ReadKey();
        }
       
    }
}
