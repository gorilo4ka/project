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
           // int i;
            //bool result;
            string s;
           
            
            foreach (var item in Reader.Persons)
            {
                Console.WriteLine(item);
            }
            
            Console.ReadLine();
            /*
            do
            {
                Console.WriteLine("Меню:");
                Console.WriteLine("1-Создание персоны.");
                Console.WriteLine("2-Создание проекта.");
                Console.WriteLine("3-Чтение проекта.");
                s = Console.ReadLine();
                result = Int32.TryParse(s, out i);
                if (!result || i > 3 || i < 1)
                {
                    Console.WriteLine("Неправильный ввод");
                }

            } while (!result||i>3||i<1);
           
            


            switch (i)
            {
                case 1:
                    Person new_Client = new Person();                   
                    break;
                case 2:
                    Project new_Project = new Project();
                    break;
                case 3:
                    prnt();
                    break;

            }
                       

            Console.ReadLine();
        }
        public static void prnt()
        {
            StreamReader sr=null;
            try
            {
                 sr = new StreamReader("D:\\Project.txt");
            }
            catch (Exception)
            {

                Console.WriteLine("Проэкт не создан");
                return;
            }
            
            int i;
            bool result;
            string s;
            do
            {
                Console.WriteLine("Введите Id проэкта");
                s = Console.ReadLine();
                result = Int32.TryParse(s, out i);
                if (!result || i > 99 || i < 0)
                {
                    Console.WriteLine("Неправильный ввод");
                }
               
            } while (!result || i > 99 || i < 0);
            for (int k = 0; k < i; k++)
                sr.ReadLine();
            string str=sr.ReadLine();
            string[] array=null;
            try
            {
                 array = str.Split('@');
            }
            catch (Exception)
            {

                Console.WriteLine("Не существующий Id");
                return;
            }
            
            string[] arrays = new string[19];
            arrays[1] = "Сроки выполнения -- ";
            arrays[2] = "планируемый бюджет -- ";
            arrays[3] = "реальный бюджет -- ";
            arrays[4] = "список Персон -- ";
            arrays[5] = "список заданий -- ";
            arrays[6] = "ответственный исполнитель -- ";
            arrays[7] = "статус завершения -- ";
            for (int k = 0; k < array.Length; k++)
            {
                Console.WriteLine(arrays[k]+ array[k]);
               
                if (k==5)
                {

                    using (StreamReader srt = new StreamReader("D:\\Tasks.txt"))
                    {
                string idpr = null;
                        int ids = 1;
                       
                        while (!srt.EndOfStream)
                {
                    idpr = srt.ReadLine();
                          
                            int index = idpr.IndexOf("idpe=");
                    string index_Pers = null;
                    int index_pers = -1;
                            if (idpr.Contains("idPr=" + i))
                    {
                                
                                int j = 5;

                        do
                        {

                            index_Pers = index_Pers + idpr[index + j];
                            j++;

                        } while (idpr[index + j] != '@');
                                
                                Console.Write("Задание "+ids+":");
                                
                                string[] tasks = idpr.Split('@');
                                Console.WriteLine(tasks[1]);
                                index_pers = Convert.ToInt32(index_Pers);
                          
                                prnt_per(index_pers,ids);
                                ids++;
                            }
                   
                }
            } 

                    
                    
                }
            }
            
        }

        public static void prnt_per(int i,int idp)
        {
            StreamReader sr = new StreamReader("D:\\Client.txt");

            int metka = 0;
            while (!sr.EndOfStream)
            {
                
                string person = sr.ReadLine();

                if (person.Contains("id=" + i+ " "))
                {
                    metka = 1;
                    string[] pers = person.Split('@');
                    Console.Write("Исполнитель "+idp+":");
                    Console.WriteLine(pers[1]);
                    idp++;
                }         
                    sr.ReadLine();
            }
            if (metka==0)
            {
                Console.WriteLine("Исполнитель " + idp + ":Не существует");
            }
            sr.Close();*/
        }
    }
}
