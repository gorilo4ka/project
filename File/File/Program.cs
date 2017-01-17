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
            
            Console.WriteLine("Ввведите имя");
            string Name = Console.ReadLine();
            Console.WriteLine("Ввведите фамилию");
            string Surname = Console.ReadLine();
            Console.WriteLine("Ввведите отчество");
            string Patronymic = Console.ReadLine();
            Console.WriteLine("Ввведите адресс");
            string Adress = Console.ReadLine();
            Console.WriteLine("Ввведите список проектов");
            string List = Console.ReadLine();
            Client news= new Client(Name, Surname, Patronymic,Adress,List);           

            Console.ReadLine();
        }
    }
}
