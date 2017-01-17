using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace reading
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream file1 = new FileStream("f:\\allo.txt", FileMode.Open);
            StreamReader reader = new StreamReader(file1);          
            char [] mas1;
            string ass = reader.ReadToEnd();
            reader.Close();
            mas1 =ass.ToCharArray();
            for (int i = 0; i <mas1.Length; i++)
            {
                Console.Write(mas1[i]+"\n");
              
            }
            
            Console.ReadKey();
        }
    }
}
