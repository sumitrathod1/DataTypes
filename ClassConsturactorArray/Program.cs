using Microsoft.VisualBasic;
using System;

namespace StaticClass
{
   
    internal class Program
    {

        static class student //Static class
        {
            // Static class has only static members
            // We cannot crete a Object of a static class
            // we can call static members with the help of class name
            static string  stuName;
            static int age;
            static int year;

            static student()// Static Constructor
            {
                stuName = "Sahil";
                age = 22;
                year = 4;
            }

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

        }


        static void Main(string[] args)
        {
            student.getStddeatail();
            student.setDati();
        }
    }
}
