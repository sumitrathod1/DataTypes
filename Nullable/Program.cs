using System;

namespace Nullables
{
    internal class Program
    {
       public class A
        {
            public void show()
            {
                Console.WriteLine("hii");
            }
        }
        public class B:A
        {
            public void show()
            {
                Console.WriteLine("Hello");
            }
        }
        public class C:B
        {
            public void show()
            {
                Console.WriteLine("How Are You");
            }
        }
        static void Main(string[] args)
        {
            C c=new C();
            c.show();
            B b=new C();
            b.show();


            //int? r = 0;
            //int? s = null;
            //int a = s ?? 20;
            //int? m = 26;
            //nullable<int> n = null;
            //int k = 0;

            //console.writeline(s);
            //console.writeline(a);
            //console.writeline(n.getvalueordefault());
            //console.writeline(m.getvalueordefault());
            //console.writeline(s.hasvalue);
            //console.writeline(m.hasvalue);

            //if (nullable.compare<int>(n, r) < 0)
            //{
            //    console.writeline("less");
            //}
            //else
            //{
            //    console.writeline("greater");
            //}
        }
    }
}
