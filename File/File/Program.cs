using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace File
{

    class Program
    {
        
        static void Main(string[] args)
        { 
                Console.WriteLine("Меню:");
            Console.WriteLine("1-Создание заказчика.");
            Console.WriteLine("2-Создание проекта.");
            //Console.WriteLine("Меню:");
            int i = Convert.ToInt32(Console.ReadLine());
            switch (i)
            {
                case 1:
                    Client new_Client = new Client();                   
                    break;
                case 2:
                    Project new_Project = new Project();
                    break;
            }
                       

            Console.ReadLine();
        }
    }
}
