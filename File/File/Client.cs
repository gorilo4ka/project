using System;
using System.IO;
namespace File
{
    internal class Client
    {
          string Name;
          string Surname;
          string Patronymic;
          string Adress;
          string List;
         public Client(string name, string surname, string patronymic, string adress, string list)
        {
            FileStream file1 = new FileStream("F:\\Client.txt", FileMode.Create, FileAccess.Write);
            this.Name = name;
            this.Surname = surname;
            this.Patronymic = patronymic;
            this.Adress = adress;
            this.List = list;
            using (StreamWriter writer = new StreamWriter(file1))
            {
                
                writer.WriteLine(Name);
                
                writer.WriteLine(Surname);

                writer.WriteLine(Patronymic);

                writer.WriteLine(Adress);

                writer.WriteLine(List);
            }
            file1.Close();
        }

                
    }
}