using System;
using System.IO;
namespace File
{
    public class My_Task
    {

        private string name;
        private double id_Task;
        private double id_Person;
        private double id_Project;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public double Id_Task
        {
            get { return id_Task; }
            set { id_Task = value; }
        }
        public double Id_person
        {
            get { return id_Person; }
            set { id_Person = value; }
        }
        public double Id_Project
        {
            get { return id_Project; }
            set { id_Project = value; }
        }
    }
}
