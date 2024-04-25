using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamA;
using TeamA.TeamB;

namespace NameSpace
{
    public class Sumit:B
    {
        public int num = 10;
        private int num2 =20;
        protected int num3 = 30;
        internal int num4 = 40;
        internal protected int num5=50;
        public void sss()
        {
            Console.WriteLine(num);
            Console.WriteLine(num2);
            Console.WriteLine(num3);
            Console.WriteLine(num4);
            Console.WriteLine(num5);
            Console.WriteLine("namespace");
        }
        static void Main(string[] args)
        {
            TeamA.A a=new TeamA.A(); // calling the namespace from teamB and class A
            a.print();

            TeamA.TeamB.B b=new TeamA.TeamB.B(); // calling the namespace from teamB and class B
            b.show();
            int n=b.d;
            Console.WriteLine(n);

            Sumit s = new Sumit();
            
            Console.WriteLine("inherited in the same assemble " + s.b);
            Console.WriteLine("inherited in the same assemble" + s.d);
            Console.WriteLine("inherited in the same assemble" + s.e);


            int c = a.a + b.b; // creating local variable and using other nameSpaces class Variables
            Console.WriteLine(c);
            Console.ReadLine();

        }
    }
}

namespace TeamA
{
    namespace TeamB// Nested name space
    {
        public class B
        {
            public int b = 20;
            private int c = 30;
            internal int d = 40;
            protected int e = 50;
            public void show()
            {
                Console.WriteLine("Hii i am teamB");
            }
        }
    }

    public class A
    {
        public int a = 10;
        public void print()
        {
            Console.WriteLine("Hii i am teamA");
        }
    }
}