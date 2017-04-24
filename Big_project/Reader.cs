using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace File
{
     class Reader
    {
        List<My_Task> tasks = null;
        public List<My_Task> Task
        {
            
            get { return tasks; }
            set
            {
                if (tasks==null)
                {
                    tasks= new List<My_Task>();                    
                }
                tasks = value;
            }
        }
        List<Person> persons = null;
        public List<Person> Person
        {
            get { return persons; }
            set {
                if (persons == null)
                {
                    persons = new List<Person>();
                }
                persons = value; }
        }
        List<Project> projects = null; 
        public List<Project> Project
        {
            get { return projects; }
            set {
                if (projects == null)
                {
                    projects = new List<Project>();
                }
                projects = value; }
        }

        public void Read_Proj()
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
                    Project.Add(new_proj);
                }
            }
            catch (Exception)
            {

            }
        }
        public void Read_Person()
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

                    Person.Add(new_pers);
                }
            }
            catch (Exception)
            {
            }
        }
        public void Read_Task()
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
                    Task.Add(new_Task);
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