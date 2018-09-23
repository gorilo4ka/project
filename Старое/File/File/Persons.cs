using System;
using System.IO;
namespace File
{
    public class Persons
    {
        private string name;
        private string surname;
        private string patronymic;
        private string adress;
        private string list;
        private double id;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }
        public string Patronymic
        {
            get { return patronymic; }
            set { patronymic = value; }
        }
        public string Adress
        {
            get { return adress; }
            set { adress = value; }
        }
        public string List
        {
            get { return list; }
            set { list = value; }
        }
        public double Id
        {
            get { return id; }
            set { id = value; }
        }

        public Persons()
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
