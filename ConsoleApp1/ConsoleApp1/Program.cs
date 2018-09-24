using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
     class Program
    {

        static void Main(string[] args)
        {    int x,y=50,z;
             Console.WriteLine("Введите размер массива");            
            String s= Console.ReadLine();    
             bool isNumx = int.TryParse(s, out x);
            if (!isNumx||x<1)
            {       
                return;                
            }

            /*Console.WriteLine("Введите границу");

            s = Console.ReadLine();
            Int32.TryParse(s, out y);
            bool isNumy = int.TryParse(s, out y);
            if (!isNumy)
            {
                y =50;
            }*/

            int[] mas = Task.Task_massive(x,y);

            Console.WriteLine("Массив");
            foreach (int a in Task.Task_massive(x, y))
             Console.Write($"{a}|");
            Console.WriteLine();

            Console.WriteLine("Введите шаг сдвига");
            s = Console.ReadLine();           
            bool isNumz = int.TryParse(s, out z);
            if (!isNumz)
            {
                return;
            }

            Console.WriteLine("После сдвига");            
            foreach (int a in Task.Massive_change(mas,z))
                Console.Write($"{a}|");
            Console.ReadLine();
           
        }

    }
    

     public static class Task
    {
        
        public static int[] Task_massive(int length,  int max_value=50)
        {


            int[] Massive = new int[length];
            Random rand = new Random();
            for (int i = 0; i < Massive.Length; i++)
                Massive[i] = rand.Next(max_value);
            return Massive;
            
        }

        public static int[] Massive_change(int [] massive,int change)
        {          
            int[] new_massive = new int[massive.Length];

            if (change % massive.Length == 0) return massive;
            else change = change % massive.Length;  
            
            Array.Copy(massive, 0 , new_massive, change, massive.Length - change);
            new_massive[0] = massive[massive.Length - change];
            for (int i = 1; i < change; i++)
            {
                new_massive[change-i] = massive[massive.Length -i];
                
            }
            return new_massive;
        }

    }
}