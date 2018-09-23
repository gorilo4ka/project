using System;
using System.IO;

namespace File
{
    class Project
    {
        private string dead_Line;
        private string planned_budget;
        private string real_budget;
        private string client_List;
        private string task_List;
        private string performer;
        private string complete_Status;
        private double id;

        public string Dead_Line
        {
            get { return dead_Line; }
            set { dead_Line = value; }
        }
        public string Planned_budget
        {
            get { return planned_budget; }
            set { planned_budget = value; }
        }
        public string Real_budget
        {
            get { return real_budget; }
            set { real_budget = value; }
        }
        public string Client_List
        {
            get { return client_List; }
            set { client_List = value; }
        }
        public string Task_List
        {
            get { return task_List; }
            set { task_List = value; }
        }
        public string Performer
        {
            get { return performer; }
            set { performer = value; }
        }
        public string Complete_Status
        {
            get { return complete_Status; }
            set { complete_Status = value; }
        }
        public double Id
        {
            get { return id; }
            set { id = value; }
        }
        public Project()
        {

            string s = null;
            try
            {
                StreamReader sr = new StreamReader("F:\\Project.txt");
                s = sr.ReadToEnd();
                sr.Close();
            }
            catch (Exception)
            {
                
                StreamWriter text = new StreamWriter("F:\\Project.txt");
                text.Close();
            }
            StreamWriter texts = new StreamWriter("F:\\Project.txt",true);
            StreamWriter Cleint = new StreamWriter("F:\\Client.txt");
            id = 0;
            string oop = "";
            char ravno = '=';
            texts.Write("id=" + (id) + " ---- ");
            Console.WriteLine("Ввведите Сроки выполнения");
            Dead_Line = Console.ReadLine();
            texts.Write(Dead_Line + "@");
            Console.WriteLine("Ввведите планируемый бюджет");
            planned_budget = Console.ReadLine();
            texts.Write(planned_budget + "@");
            Console.WriteLine("Ввведите реальный бюджет");
            real_budget = Console.ReadLine();
            texts.Write(real_budget + "@");
            int i = -1;
            while ( i !=0)
            {
                Console.WriteLine("Ввведите список заказчиков.ФИО через пробел");
                Client_List = Console.ReadLine();
                texts.Write(Client_List + "@");
                string op = " ---- ";
                string ss = null;
                
                Console.WriteLine("1-Ввести еще заказчиков,0 выход.");
                string List = Console.ReadLine();
                i = Convert.ToInt32(List);
            
            }


            Console.WriteLine("Ввведите список заданий в проекте");
            Task_List = Console.ReadLine();
            texts.Write(Task_List + "@");
            Console.WriteLine("Ввведите ответственного исполнителя");
            Performer = Console.ReadLine();
            texts.Write(Performer + "@");
            Console.WriteLine("Ввведите статус завершения");
            Complete_Status = Console.ReadLine();
            texts.WriteLine(Complete_Status + "@");

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
            using (texts)
            {          
            }

        }
    }
}
