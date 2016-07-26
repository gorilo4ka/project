using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        enum elements 
        {
            empty,
            X,
            O,
            t           
        }

        static bool Check_Win(elements[,] square,int quant,elements test)
        {
            //Vertikal`

            for (int i = 0; i < square.GetLength(0); i++)
            {
                int SumX = 0;
                for (int j = 0; j < square.GetLength(0); j++)
                {
                    if (square[j, i] == test)
                    {
                        SumX++;
                        if (SumX == quant)
                        {
                            return true;
                        }
                    }  
                    else                  
                  SumX = 0;                   
                }        
            }
            //Gorizontal`
            for (int i = 0; i < square.GetLength(0); i++)
            {
                int SumX = 0;
                for (int j = 0; j < square.GetLength(0); j++)
                {
                    if (square[i, j] == test)
                    {
                        SumX++;
                        if (SumX == quant)
                        {
                            return true;
                        }
                    }
                    else
                        SumX = 0;
                }
            }
            //Diagonal`(1)
            for (int i = quant-1; i < square.GetLength(0); i++)
            {
                int SumX = 0;
                for (int j = 0; j < i+1; j = j + 1)
                {
                   
                    if (square[i - j, j] == test)
                    {                        
                           SumX++;
                        if (SumX == quant)
                        {
                            return true;
                        }
                    }
                    else
                        SumX = 0;                                    
                }               
            }

            //Diagonal`(2)
            for (int i = quant - 1; i < square.GetLength(0); i++)
            {
                int SumX = 0;
                for (int j = 0; j < i + 1; j = j + 1)
                {
                    if (square[(square.GetLength(0) - 1) - j, i - j] == test)
                    {
                        SumX++;
                        if (SumX == quant)
                        {
                            return true;
                        }
                    }
                    else
                        SumX = 0;
                }

            }

            //Diagonal`(3)
            for (int i = quant - 1; i < square.GetLength(0); i++)
            {
                int SumX = 0;
                for (int j = 0; j < i + 1; j = j + 1)
                {
                    if (square[i - j, (square.GetLength(0) - 1) - j] == test)
                    {
                        SumX++;
                        if (SumX == quant)
                        {
                            return true;
                        }
                    }
                    else
                        SumX = 0;
                }

            }

            //Diagonal`(4)
            for (int i = quant - 1; i < square.GetLength(0); i++)
            {
                int SumX = 0;
                for (int j = 0; j < i + 1; j = j + 1)
                {
                    if (square[(square.GetLength(0) - 1) - j, ((square.GetLength(0) - 1) - i) + j] == test)
                    {
                        SumX++;
                        if (SumX == quant)
                        {
                            return true;
                        }
                    }
                    else
                        SumX = 0;
                }
            }
            return false;              
        }


        


        static bool Check_X(elements[,] square,int x)
        {
            for (int i = 1; i <= square.GetLength(0); i++)
            {
                if (x == i)
                {
                    return true;
                }
            }

            return false;
        }

        static bool Check_PlaceX(elements[,] square,int x, int y)
        {
            if (square[x,y]==elements.O)
            {
                return true;
            }
            return false;
        }

        static bool Check_PlaceY(elements[,] square, int x, int y)
        {
            if (square[x, y] == elements.X)
            {
                return true;
            }
            return false;
        }



        static void Input(elements[,] square)
        {
            int Coord_X = -1; int Coord_Y = -1;
            
            while (true)
            {

                Console.WriteLine("Введите координаты X(от 1 до "+square.GetLength(0)+")");
                bool isNumber = Int32.TryParse(Console.ReadLine(), out Coord_X);
                while (!isNumber || !Check_X(square,Coord_X))
                {
                    Console.WriteLine("Error");
                    Console.WriteLine("Введите координаты X(от 1 до "+square.GetLength(0) + ")");
                    isNumber = Int32.TryParse(Console.ReadLine(), out Coord_X);
                }

                Console.WriteLine("Введите координаты Y(от 1 до " + square.GetLength(0)  + ")");
                isNumber = Int32.TryParse(Console.ReadLine(), out Coord_Y);
                while (!isNumber || !Check_X(square,Coord_Y))
                {
                    Console.WriteLine("Error");
                    Console.WriteLine("Введите координаты Y(от 1 до " + square.GetLength(0)  + ")");
                    isNumber = Int32.TryParse(Console.ReadLine(), out Coord_Y);
                }
                Coord_X = Coord_X -1 ;
                Coord_Y = Coord_Y -1 ;

                if (Check_PlaceX(square, Coord_X, Coord_Y) || Check_PlaceY(square, Coord_X, Coord_Y))
                {
                    Console.WriteLine("В данном месте находится символ противника");

                }
                else
                    break;
            }

            square[Coord_X, Coord_Y] = elements.X;
            prnt(square);

        }

        static void Turn_Bot(elements[,] square)
        {
            int Coord_X = -1; int Coord_Y = -1;
            while (true)
            {
                Random rnd = new Random();
                 Coord_X = rnd.Next(1, square.GetLength(0)+1);
                 Coord_Y = rnd.Next(1, square.GetLength(0)+1);
                Coord_X = Coord_X -1;
                Coord_Y = Coord_Y -1;
                if (!(Check_PlaceY(square, Coord_X, Coord_Y) || Check_PlaceX(square, Coord_X, Coord_Y)))
                {
                    break;
                }
            }
            square[Coord_X, Coord_Y] = elements.O;
            prnt(square);
        }
        
        static void prnt(elements[,] square)
        {
            for (int i = 0; i < square.GetLength(0); i++)
            {
                Console.Write(" "+ (i +1));
            }
                Console.WriteLine();
            for (int i = 0; i < square.GetLength(0); i++)
            {               
                    Console.Write(i  + 1);

                for (int j = 0; j < square.GetLength(0); j++)
                {
                   if(square[i, j]==elements.empty)
                    {
                        Console.Write(" ");
                    }                                     
                    else
                    Console.Write(square[i, j]);
                    Console.Write("|");
                }
                Console.WriteLine();
                for (int k = 0; k < square.GetLength(0)*2+1; k++)
                {
                    Console.Write("-");
                }
                
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            int LengX = 0;
            int quant = 0;
            Console.WriteLine("Введите размер поля");
            bool isNumber = Int32.TryParse(Console.ReadLine(), out LengX);
            while (!isNumber || LengX<3)
            {
                Console.WriteLine("Error");
                Console.WriteLine("Введите размер поля");
                isNumber = Int32.TryParse(Console.ReadLine(), out LengX);
            }

            Console.WriteLine("Введите кол-во для победы");
             isNumber = Int32.TryParse(Console.ReadLine(), out quant);
            while (!isNumber || quant > LengX||quant<3)
            {
                Console.WriteLine("Error");
                Console.WriteLine("Введите кол-во для победы");
                isNumber = Int32.TryParse(Console.ReadLine(), out quant);
            }

            elements[,] square = new elements[LengX, LengX];
            prnt(square);
            
            int text=5;
            do
            {
                if(Check_Win(square,quant,elements.O))
                {
                    text = 1;
                    break;
                }
                Input(square);
                Turn_Bot(square);
            }
            while (!Check_Win(square,quant,elements.X));
            if(text==1)            
                Console.WriteLine("Ты кот");
            else            
            Console.WriteLine("Тебе удалось это аутист");
            Console.ReadKey();
        }
       
    }
}