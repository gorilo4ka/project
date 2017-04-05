using System;
using System.Collections.Generic;
using System.IO;

namespace File
{
    
   
    enum  Status
    {
        Start,
        Proces,
        Finish        
    }
    class Project
    {
        private string dead_Line;
        private double planned_budget;
        private double real_budget;
        private List<Person> client_List;
        private List <My_Task> task_List;
        private string performer;
        private Status complete_Status;
        private int id;
        private string date_time;

        public string Dead_Line
        {
            get { return dead_Line; }
            set { dead_Line = value; }
        }
        public double Planned_budget
        {
            get { return planned_budget; }
            set { planned_budget = value; }
        }
        public double Real_budget
        {
            get { return real_budget; }
            set { real_budget = value; }
        }
        public List<Person> Client_List
        {
            get { return client_List; }
            set { client_List = value; }
        }
        public List<My_Task> Task_List
        {
            get { return task_List; }
            set { task_List = value; }
        }
        public string Performer
        {
            get { return performer; }
            set { performer = value; }
        }
        public Status Complete_Status
        {
            get { return complete_Status; }
            set { complete_Status =value; }
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Date_Time
        {
            get { return date_time; }
            set { date_time = value; }
        }
        public Project()
        {
            /*string s = null;
            try
            {
                StreamReader sr = new StreamReader("D:\\Project.txt");

                s = sr.ReadToEnd();
                sr.Close();
            }
            catch (Exception)
            {

                StreamWriter text = new StreamWriter("D:\\Project.txt");
                text.Close();
            }
            StreamWriter texts = new StreamWriter("D:\\Project.txt", true);
            string line = null;
            StreamReader Cleint = null;
            try
            {
                Cleint = new StreamReader("D:\\Client.txt");
            }
            catch (Exception)
            {
                Console.WriteLine("Файл клиент не создан");
                return;
            }
            Id = 0;
            string oop = "";
            char ravno = '=';
            try
            {
                int count = 1;
                do
                {
                    oop = oop + char.ToString(s[s.LastIndexOf(ravno) + count]);
                    count++;
                } while (char.ToString(s[s.LastIndexOf(ravno) + count]) != "-");
                id = Convert.ToUInt32(oop);
                id++;
            }
            catch (Exception)
            { }
            texts.Write("id=" + (id) + " ---- ");
            Console.WriteLine("Ввведите Сроки выполнения");
            Dead_Line = Console.ReadLine();
            texts.Write("@" + Dead_Line + "@");
            Console.WriteLine("Ввведите планируемый бюджет");
            Planned_budget = Console.ReadLine();
            texts.Write(planned_budget + "@");
            Console.WriteLine("Ввведите реальный бюджет");
            Real_budget = Console.ReadLine();
            texts.Write(real_budget + "@");
            int i = -1;
            while (i != 0)
            {
                Console.WriteLine("Ввведите список Персон.ФИО через пробел");
                 Client_List = Console.ReadLine();


                while (!Cleint.EndOfStream)
                {

                    line = Cleint.ReadLine();
                    if (!line.Contains("@" + Client_List + "^"))
                    {
                        if (Cleint.EndOfStream)
                        {

                            int j;
                            bool result;
                            string sk;

                            do
                            {
                                Console.WriteLine("Такой персоны нет в базе.Добавить в проект?1-Да,0-Нет");
                                sk = Console.ReadLine();
                                result = Int32.TryParse(sk, out j);
                                if (!result || j > 1 || j < 0)
                                {
                                    Console.WriteLine("Неправильный ввод");
                                }

                            } while (!result || j > 1 || j < 0);

                            if (j == 1)
                            {
                                texts.Write(Client_List + " ");
                            }

                        }

                    }
                    else
                    {
                        Console.WriteLine("Такая персона есть в базе.Добавлен.");
                        texts.Write(Client_List + " ");
                        break;
                    }
                   

                }
                Cleint.Dispose();
                Cleint = new StreamReader("D:\\Client.txt");

                bool results;
                string ssk;

                do
                {
                    Console.WriteLine("1-Ввести еще персон,0 выход.");
                    ssk = Console.ReadLine();
                    results = Int32.TryParse(ssk, out i);
                    if (!results || i > 1 || i < 0)
                    {
                        Console.WriteLine("Неправильный ввод");
                    }

                } while (!results || i > 1 || i < 0);
               
            }

            Console.WriteLine("Ввведите список заданий в проекте");
            Task_List = Console.ReadLine();
            texts.Write("@" +Task_List + "@");
            Console.WriteLine("Ввведите ответственного исполнителя");
            Performer = Console.ReadLine();
            texts.Write(Performer + "@");
            Console.WriteLine("Ввведите статус завершения");
           
            texts.WriteLine(Complete_Status +"@");
            texts.Close();*/

        }
    }
}
