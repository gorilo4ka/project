using System;
using System.IO;
using System.Collections.Generic;
namespace File
{
    public class My_Task
    {

        private string name;
        private int id_Task;
        private List<Person> list_Person;
        private int id_Project;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Id_Task
        {
            get { return id_Task; }
            set { id_Task = value; }
        }
        public List<Person> List_Person
        {
            get { return list_Person; }
            set { list_Person = value; }
        }
        public int Id_Project
        {
            get { return id_Project; }
            set { id_Project = value; }
        }
    }
}
