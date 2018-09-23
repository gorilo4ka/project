using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Интересные_свойтва
{
    class Program
    {
        interface Icloud1
        {
            void method1();
        }
        interface Icloud2
        {
            void method1();
            void method2();
        }
        interface Icloud3
        {
            void method1();
            void method2();
            void method3();
        }
        class A:Icloud1,Icloud2,Icloud3
        {

             void Icloud1.method1()
            {
               
                Console.WriteLine("anus");
           
               
            }
            void Icloud2.method1()
            {

                Console.WriteLine("anus2");


            }
            void Icloud2.method2()
            {

                Console.WriteLine("anus2");


            }
            void Icloud3.method1()
            {

                Console.WriteLine("anus3");


            }
            void Icloud3.method2()
            {

                Console.WriteLine("anus3");


            }
            void Icloud3.method3()
            {

                Console.WriteLine("anus3");


            }

            public  void methA()
            {
                Icloud1 a_ob;
                a_ob = this;
                a_ob.method1();
            }
            public void methB()
            {
                Icloud2 a_ob;
                a_ob = this;
                a_ob.method1();
                a_ob.method2();
            }
            public void methC()
            {
                Icloud3 a_ob;
                a_ob = this;
                a_ob.method1();
                a_ob.method2();
                a_ob.method3();
            }

        }
        static void Main(string[] args)
        {
            A obj=new A();
            obj.methA();
            obj.methB();
            obj.methC();
            Console.ReadKey();
        }
    }
}
