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
            Double id = 0;
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
            string Dead_Line = Console.ReadLine();
            texts.Write("@" + Dead_Line + "@");
            Console.WriteLine("Ввведите планируемый бюджет");
            string planned_budget = Console.ReadLine();
            texts.Write(planned_budget + "@");
            Console.WriteLine("Ввведите реальный бюджет");
            string real_budget = Console.ReadLine();
            texts.Write(real_budget + "@");
            int i = -1;
            while (i != 0)
            {
                Console.WriteLine("Ввведите список Персон.ФИО через пробел");
                string Client_List = Console.ReadLine();


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
            string Task_List = Console.ReadLine();
            texts.Write("@" +Task_List + "@");
            Console.WriteLine("Ввведите ответственного исполнителя");
            string Performer = Console.ReadLine();
            texts.Write(Performer + "@");
            Console.WriteLine("Ввведите статус завершения");
            string Complete_Status = Console.ReadLine();
            texts.WriteLine(Complete_Status + "@");
            texts.Close();

        }
    }
}
