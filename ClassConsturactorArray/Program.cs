using Microsoft.VisualBasic;
using System;

namespace StaticClass
{
   
    internal class Program
    {
       
      public  static class student //Static class
        {
            // Static class has only static members we cannot create non static data members
            // We cannot crete a Object of a static class
            
            static string  stuName;
            static int age;
            static int year;
           // int reno; we cannot create non static data members it gives an compile time error

           static student()// Static Constructor // access modifires are not allow on static constructors
            {
                stuName = "Sahil";
                age = 22;
                year = 4;
            }

            // public student() { Console.WriteLine("a"); }; static class cannot have a instance constructors

            public static void getStddeatail() // Static method
            {
                Console.WriteLine("Name: {0}",stuName);
                Console.WriteLine("Age: {0}",age);
                Console.WriteLine("Year: {0}",year);
            }

            public static void setDati()//Static method
            {
                Console.WriteLine("name is changed: {0}",stuName="aaa");
                Console.WriteLine(age-1);
            }

            //public void Itc() we cannot create non static methods
            //{
            //    Console.WriteLine("non static");
            //}

        }
       class nostaticclass
        {
            int a = 30;
            static int b = 20; // in non static class we can create static data member also
  
             static nostaticclass()
            {
                Console.WriteLine("Hello");
            }
            static void sub()
            {
                Console.WriteLine("static mathod in non static class");// in non static class we can create static method
            }
        }

        static void Main(string[] args)
        {
            student.getStddeatail(); // we can call static members with the help of class name
            student.setDati();
        }
    }
}
