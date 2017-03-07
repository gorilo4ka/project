using System;
using System.IO;
namespace File
{
    public class Client
    {
        private string Name;
        private string Surname;
        private string Patronymic;
        private string Adress;
        private string List;
        private double id;

        public string name
        {
            get { return Name; }
            set { Name = value; }
        }
        public string surname
        {
            get { return Surname; }
            set { Surname = value; }
        }
        public string patronymic
        {
            get { return Patronymic; }
            set { Patronymic = value; }
        }
        public string adress
        {
            get { return Adress; }
            set { Adress = value; }
        }
        public string list
        {
            get { return List; }
            set { List = value; }
        }
        public double Id
        {
            get { return id; }
            set { id = value; }
        }

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
             Name = Console.ReadLine();

        Console.WriteLine("Ввведите фамилию");
             Surname = Console.ReadLine();
            Console.WriteLine("Ввведите отчество");
             Patronymic = Console.ReadLine();
            Console.WriteLine("Ввведите адресс");
             Adress = Console.ReadLine();
            Console.WriteLine("Ввведите список проектов");
             List = Console.ReadLine();

             id = 0;
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
