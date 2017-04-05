using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File
{
     class  Reader
    {
        List<My_Task> Tasks = new List<My_Task>();
        public List<My_Task> task
        {
            get { return Tasks; }
            set { Tasks = value; }
        }
        List<Person> Persons = new List<Person>();
        public List<Person> person
        {
            get { return Persons; }
            set { Persons = value; }
        }
        List<Project> Projects = new List<Project>();
        public List<Project> project
        {
            get { return Projects; }
            set { Projects = value; }
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
                    Project New_Proj = new Project();
                    string[] str= s.Split('@');
                    Console.Write(str[0]);
                    New_Proj.Id = Convert.ToInt32(str[0]);                    
                    New_Proj.Dead_Line = str[1];
                    New_Proj.Planned_budget = Convert.ToDouble(str[2]);
                    New_Proj.Real_budget = Convert.ToDouble(str[3]);
                    New_Proj.Client_List = str[4];
                    New_Proj.Task_List = str[5];
                    New_Proj.Performer = str[6];
                    New_Proj.Complete_Status =(Status)Enum.Parse(typeof(Status),str[7]);
                    New_Proj.Date_Time = str[8];
                    project.Add(New_Proj);
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