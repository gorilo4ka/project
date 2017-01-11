using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ProjectFirm
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream file = new FileStream(("F:\\allo.txt"), FileMode.Create);
            StreamWriter file1 = new StreamWriter(file);

            for (int i = 1; i < 10; i++)
            {
               
                for (int j = 1; j < 10; j++)
                {
                    file1.Write(i*j+ "\t");            
                }
                file1.WriteLine("\n");
            }
               
            file1.Close();
            using (StreamReader sr = new StreamReader(@"F:\\allo.txt"))
            { 
            String line = sr.ReadToEnd();
            
               
            Console.WriteLine(line);
        }
            Console.ReadKey();

        }
    }
}
