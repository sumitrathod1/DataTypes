using System;
using System.Numerics;
using System.Xml.Linq;

namespace inheritancess
{
    internal class Program
    {
        // Single inheritance 
        class A
        {
            public void cource()
            {
                Console.WriteLine("I am \"A\" Class and my cource is Dot NET");
            }
        }
        class B : A
        {
            public void cource2()
            {
                Console.WriteLine("I am \"B\" Class and my cource is Java");
            }
        }

        //multi level inheritance
        class C : A
        {
            public void cource3()
            {
                Console.WriteLine("I am \"C\" Class And my cource is python");
            }
        }

        //herarical inheritance

        class D : B
        {
            public void cource4()
            {
                Console.WriteLine("I am herarical inheritance and my cource is Data analysis");
            }
        }

        //multiplae inheritance

        interface mul
        {
            void m1();
        }

        interface mul2
        {
            void m2();
        }

        class mulMain : mul, mul2
        {
            public void m1()
            {
                Console.WriteLine("hi I'am \"m1\" mltiple inheritance");
            }
            public void m2()

            {
                Console.WriteLine("hi I'am \"m2\" mltiple inheritance");
            }
            public void main()
            {
                Console.WriteLine("Hi I'am \"main\" multiple inheritance");
            }
        }
        static void Main(string[] args)
        {

            B b = new B();// single inheritance
            b.cource();
            b.cource2();

            C c = new C();//multi level inhertitance
            c.cource3();
            c.cource();

            D d = new D(); // multi level inheritance
            d.cource();
            d.cource2();
            d.cource4();

            mulMain m=new mulMain();
            m.main();
            m.m1();
            m.m2();
            
        }
    }
}
