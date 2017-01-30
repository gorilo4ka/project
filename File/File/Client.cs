using System;
using System.IO;
namespace File
{
    public class Client
    {
        
        
         public Client()
        {
            string s=null;
            try
            {
                StreamReader sr = new StreamReader("F:\\Client.txt");
                 s = sr.ReadToEnd();
                sr.Close();
            }
            catch (Exception)
            {
                StreamWriter text = new StreamWriter("F:\\Client.txt");
                text.Close();
            }
            


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

            Double id = 0;
            string oop="";
            char ravno = '=';
            try
            {
                int count = 1;
                do
                {
                    oop =oop+ char.ToString(s[s.LastIndexOf(ravno) + count]);
                    count++;
                } while (char.ToString(s[s.LastIndexOf(ravno) + count]) != "-");
                id = Convert.ToUInt32(oop);
                id++;
            }
            catch (Exception)
            { }


            using (StreamWriter writer = new StreamWriter("F:\\Client.txt",true))
            {
                 writer.Write("id="+(id)+ " ---- ");
                writer.Write(Name+"^");

                 writer.Write(Surname + "^");

                 writer.Write(Patronymic + "^");

                 writer.Write(Adress + "^");

                 writer.WriteLine(List + "^");           
                 writer.Close();
             
            }
        }
    }
}
