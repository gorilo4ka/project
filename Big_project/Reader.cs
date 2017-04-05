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
        List<My_Task> task = new List<My_Task>();
        public List<My_Task> Task
        {
            get { return task; }
            set { task = value; }
        }
        List<Person> person = new List<Person>();
        public List<Person> Person
        {
            get { return person; }
            set { person = value; }
        }
        List<Project> project = new List<Project>();
        public List<Project> Project
        {
            get { return project; }
            set { project = value; }
        }

        public void Read_Proj()
        {
            string s = null;
            
            try
            {

               
                StreamReader sr = new StreamReader("D:\\Project.txt");
                Project New_Proj = new Project();
                while (!sr.EndOfStream)
                {                   
                    s = sr.ReadLine();
                   
                    string[] str= s.Split('@');
                    
                   

                    New_Proj.Id = Convert.ToDouble(str[0]);                    
                    New_Proj.Dead_Line = str[1];
                    New_Proj.Planned_budget = str[2];
                    New_Proj.Real_budget = str[3];
                    New_Proj.Client_List = str[4];
                    New_Proj.Task_List = str[5];
                    New_Proj.Performer = str[6];
                    New_Proj.Complete_Status =(Status)Enum.Parse(typeof(Status),str[7]);
                   
                       
                }

                project.Add(New_Proj);
                foreach (var item in project)
                {
                    Console.Write(item);
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