using System;

namespace Delegates
{
   public delegate void calculator(int k, int l);

    public delegate int anonimu(int num);
    internal class Program
    {
        public static void add(int a, int b)
        {
            Console.WriteLine(a+b);
        }
        public static void sub(int a, int b)
        {
            Console.WriteLine( a - b);
        }
        public static void mul(int a, int b)
        {
            Console.WriteLine( a * b);
        }
        public static void div(int a, int b)
        {
            Console.WriteLine( a / b);
        }

        static public void anoni(anonimu dno,int a)
        {
            a *= 10;
             dno.Invoke(a);
        }
        static void Main(string[] args)
        {
            anonimu del =  (int a) =>
            {
                a*=10;
            return(a);
            };
            del(2);

            anonimu del1 = (a) => a * a;
            Console.WriteLine(del1(2)) ;
            //Program.anoni(delegate (int b) { b += 10; Console.WriteLine(b); },10);//anonymous method

            calculator cal = new calculator(Program.add);
            cal(20, 30);
            cal = sub;
            cal(20, 10);
            cal = mul;
            cal(20, 20);
            cal = div;
            cal(20, 20);

            Console.WriteLine("--------------------------------------------");

            calculator cal2 = new calculator(Program.add);
            cal2 += sub;
            cal2 += mul;
            cal2 += div;
            cal2(2,3);
            Console.ReadLine();
        }
    }
}
