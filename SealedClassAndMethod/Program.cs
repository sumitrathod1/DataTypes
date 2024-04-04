using System;

namespace SealedClassAndMethod
{
    internal class Program
    {
        sealed class A // sealed Class are used to protect to inherited by other class
        {
            public void show()
            {
                Console.WriteLine("hi I am Class A");
            }
        }
        //public class B:A We Cannot Inherite the class beacause that class is sealed it will give an compile time error
        //{
        //    public void show()
        //    {
        //        Console.WriteLine("hi I am Class A");
        //    }
        //}


        // Sealed Method 
        // sealed Method are used to privent the ovrride the method 
        class X
        {
            public virtual void print() // Virtual method
            {
                Console.WriteLine(@"Hii i am class 'X'");
            }
        }

        class Y:X
        {
            public sealed override void print() // sealed method
            {
                Console.WriteLine(@"Hii i am class 'Y'");
            }
        }

        class Z : Y
        {
            //public override void print()// we cannot create a method by sealed by parent claas Y it will through an compile time error 
            //{
            //    Console.WriteLine(@"Hii i am class 'Z'");
            //}
        }
        static void Main(string[] args)
        {
            X x= new Z();
            x.print();
        }
    }
}
