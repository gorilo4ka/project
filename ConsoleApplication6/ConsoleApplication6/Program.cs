using System;

namespace MenuApp
{
    public class Numbers
    {
        
        string[] Number = new string[9];
   

        public string this[int stringIndex]
        {
            //get { return Number[stringIndex]; }
            set { Number[stringIndex] = value; }
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
          
            Numbers Chisla = new Numbers();
            for (int i = 0; i < 9; i++)
            {
                Chisla[i] = i.ToString();

            }                
            
            Console.WriteLine(Chisla[8]);
            Console.ReadKey();
        }
    }
}