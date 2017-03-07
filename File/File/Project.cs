using System;
using System.IO;

namespace File
{
    class Project
    {
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
            Double id = 0;
            string oop = "";
            char ravno = '=';
            texts.Write("id=" + (id) + " ---- ");
            Console.WriteLine("Ввведите Сроки выполнения");
            string Dead_Line = Console.ReadLine();
            texts.Write(Dead_Line + "@");
            Console.WriteLine("Ввведите планируемый бюджет");
            string planned_budget = Console.ReadLine();
            texts.Write(planned_budget + "@");
            Console.WriteLine("Ввведите реальный бюджет");
            string real_budget = Console.ReadLine();
            texts.Write(real_budget + "@");
            int i = -1;
            while ( i !=0)
            {
                Console.WriteLine("Ввведите список заказчиков.ФИО через пробел");
                string Client_List = Console.ReadLine();
                texts.Write(Client_List + "@");
                string op = " ---- ";
                string ss = null;
                
                Console.WriteLine("1-Ввести еще заказчиков,0 выход.");
                string List = Console.ReadLine();
                i = Convert.ToInt32(List);
            
            }


            Console.WriteLine("Ввведите список заданий в проекте");
            string Task_List = Console.ReadLine();
            texts.Write(Task_List + "@");
            Console.WriteLine("Ввведите ответственного исполнителя");
            string Performer = Console.ReadLine();
            texts.Write(Performer + "@");
            Console.WriteLine("Ввведите статус завершения");
            string Complete_Status = Console.ReadLine();
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
