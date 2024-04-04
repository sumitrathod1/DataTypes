using System;

namespace RefAndOUT
{
    internal class Program
    {
        public static void noirmalmeth(int a)
        {
            a=a+1;
            Console.WriteLine("This is normal "+a);
        }

        public static void CallbyRef(ref int a)
        {
            a=a+1;
            Console.WriteLine("This is call by ref "+a);
        }

        public static void CallbyOut(out int a)
        {
            a = 10;
            Console.WriteLine("This is call by out "+a);
        }
        static void Main(string[] args)
        {
            int value = 1;
            noirmalmeth(value);
            Console.WriteLine( "This is normal "+value);

            int Value1=1 ;
            CallbyRef(ref Value1);
            Console.WriteLine("This is call by Ref "+Value1);

            int Value2;
            CallbyOut(out Value2);
            Console.WriteLine("This is Callby out "+Value2);
        }
    }
}
