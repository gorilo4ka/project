using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace File
{
     static class Reader
    {
        static List<My_Task> tasks = null;
        public static List<My_Task> Tasks
        {
            
            get {
                if (tasks == null)
                {
                    tasks = new List<My_Task>();
                    Read_Task();
                }
                return tasks; }
            set
            {

                tasks = value;
            }
        }
        static List<Person> persons = null;
        public static List<Person> Persons
        {

            get {
                if (persons == null)
                {
                    persons = new List<Person>();
                    Read_Person();
                }
                return persons; }
            set {               
                persons = value;
                }

        }
        static List<Project> projects = null; 
        public static List<Project> Projects
        {
            get {
                if (projects == null)
                {
                    projects = new List<Project>();
                    Read_Proj();
                }
                return projects; }
            set {

                projects = value; }
        }

        public static void Read_Proj()
        {
            string s = null;
            try
            {
                StreamReader sr = new StreamReader("D:\\Project.txt");
                while (!sr.EndOfStream)
                {
                    s = sr.ReadLine();
                    Project new_proj = new Project();
                    string[] str = s.Split('@');
                    Console.Write(str[0]);
                    new_proj.Id = Convert.ToInt32(str[0]);
                    new_proj.Dead_Line = str[1];
                    new_proj.Planned_budget = Convert.ToDouble(str[2]);
                    new_proj.Real_budget = Convert.ToDouble(str[3]);
                    new_proj.Client_List = Convert.ToInt32(str[4]); 
                   // new_proj.Task_List = str[5];
                    new_proj.Performer = str[6];
                    new_proj.Complete_Status = (Status)Enum.Parse(typeof(Status), str[7]);
                    new_proj.Date_Time = str[8];
                    Projects.Add(new_proj);
                }
            }
            catch (Exception)
            {

            }
        }
        public static void Read_Person()
        {
            string s = null;
            try
            {
                StreamReader sr = new StreamReader("D:\\Client.txt");
                while (!sr.EndOfStream)
                {
                    s = sr.ReadLine();
                    Person new_pers = new Person();
                    string[] str = s.Split('@');
                    new_pers.Id= Convert.ToInt32(str[0]);
                    new_pers.Name= str[1];
                    new_pers.Surname = str[2];
                    new_pers.Patronymic = str[3];
                    new_pers.Adress = str[4];

                    Persons.Add(new_pers);
                }
            }
            catch (Exception)
            {
            }
        }
        public static void Read_Task()
        {
            string s = null;
            try
            {
                StreamReader sr = new StreamReader("D:\\Task.txt");
                while (!sr.EndOfStream)
                {
                    s = sr.ReadLine();
                    My_Task new_Task = new My_Task();
                    string[] str = s.Split('@');
                    new_Task.Name = str[0];
                    string[] str_1 = str[1].Split('^');
                    Read_Person();
                    for (int i = 0; i < str_1.Length; i++)
                    {
                        int currentID = Convert.ToInt32(str_1[1]);
                        //Person person = Read_Person.FirstOrDefault(p => p.Id == currentID);
                    }
                    
                    new_Task.Id_Project = Convert.ToInt32(str[2]);
                    new_Task.Id_Task = Convert.ToInt32(str[3]);
                    Tasks.Add(new_Task);
                }
            }
            catch (Exception)
            {
            }
        }
    }
}
/*теперь три функции, первая из вайла проектов считывает проектики и заносит в коллекцию проджектс
*/