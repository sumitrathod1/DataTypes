using System;

namespace MethodHidding
{
    internal class Program
    {
       public class A
        {
            public virtual void print()
            {
                Console.WriteLine("This is a Base Class A");
            } 
        }
        public class B:A
        {
            public override void print()
            {
                Console.WriteLine("This is a Derived Class B");
            }
        }

        public class C : A
        {
            public override void print()
            {
                Console.WriteLine("This is a Derived Class C");
            }
        }

         class X
        {
            public virtual void show()
            {
                Console.WriteLine("I Am X");
            }
        }

         class Y:X
        {
            public override void show()
            {
                Console.WriteLine("I Am Y");
            }
        }

        class Z : Y
        {
            public new void show()
            {
                Console.WriteLine("I am Z");
            }
        }

        class pro : Z
        {
            public new void show()
            {
                Console.WriteLine("I am pro");
            }
        }

        public static int n = 10;
        public int num = 12;

        public void nnn()
        {
            Console.WriteLine(n);
            Console.WriteLine(num);
        }
        static void Main(string[] args)
        {
            //A a = new A();
            //  a.print();

            //  A b=new B();
            //  b.print();

            //  A c= new C();
            //  c.print();

            //  Y y= new Y();
            //  X x=new Y();
            //  x.show();

            //char[] chars = { 'h', 'e', 'l', 'l', 'o' };
            //string str = new string(chars);

            //for (int i = 0; i < str.Length; i++)
            //{
            //    Console.WriteLine(str[i]);
            //}
            
            
            
            Program p = new Program();
           
            
            p.nnn();
            Program.n = 20;
            Console.WriteLine(Program.n);
            p.num = 17;
            Console.WriteLine(p.num);


            //Y p = new pro();
            //p.show();

            Console.ReadLine();

        }
    }
}
