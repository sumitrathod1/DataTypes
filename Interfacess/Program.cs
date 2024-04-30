using System;
using Arrays;

namespace Interfacess
{
    //Interface 
    //Insterface is a same as a class but contains only abstract members 
    //Innterface contains only declaration of the members no implimentation. implimentation is possible in the derived class 
    // Main use of interface is it can be use as multiple inheritance
    //Interface cannot have fields
    //In interface all the members are bydefault Public
    //An method should be same name in the derived class as we declared in the interface
    internal class Program
    {
        interface A
        {
          int name { get; set; }

            void Show();
        }
        public class B:A
        {
            int A.name { get; set; }

            public void Show()
            {
                Console.WriteLine("I am interface ");
            }

        }

        interface int1
        {  
            void print1();
        }
        interface int2
        {
            void print2();
        }
        interface int3 : int1,int2
        {
            void print3();
        }

       public class orginter : int3
        {
            public void print1()
            {
                Console.WriteLine("1");
            }
            public void print2()
            {
                Console.WriteLine("2");
            }
            public void print3()
            {
                Console.WriteLine("3");
            }
        }

        static void Main(string[] args)
        {

            orginter o=new orginter();
            o.print1();
            o.print2();
            o.print3();
            //A a = new B();
            //a.Show();
            B b = new B();
            b.Show();

            A a = new B();
            a.name = 10;
            Console.WriteLine(a.name);

            Arrays.Program p = new Arrays.Program();
            p.sss();
        }
    }
}
