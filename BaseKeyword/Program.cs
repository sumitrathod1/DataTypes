using System;

namespace BaseKeyword
{
    internal class Program
    {
        class C
        {
            public C(int s)
            {
                Console.WriteLine("This is Class C "+" "+ s);
            }
        }
        class A:C
        {
           public A(int v,int a, int b): base(v)  // Base keyword to send the value to the Class C through Constructor
            {
                Console.WriteLine("This is class A "+ (a+b));
            }
        }

        class B:A 
        {

            public B(int x, int y, int l ): base (x,y,l) // Base keyword to send the value to the Class A Through Constructor
            {
                Console.WriteLine("This is a derived class");
            }
        }

        static void Main(string[] args)
        {
            A a = new A(1,2,3);

            Console.WriteLine("Hello World!");
        }
    }
}
