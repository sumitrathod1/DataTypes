using System;

namespace Methods
{
    internal class Program
    {

        public void method() // Declaring Non Static Meathod or Instance Method with void key word 
        {
            Console.WriteLine("Hi Iam a \"Method\"");       
        }
        public static void method1()// Declaring Static Meathod
        {
            Console.WriteLine("Hi Iam Static \"Method\"");
        }
        public static void Add(int a,int b)// Declaring Static With Parameterized Method
        {
            int result = a + b;
            Console.WriteLine("Hi Iam Parameterized Method "+ result);
        } 

        public static int multipli(int a, int b) // Declaring Static With Parameterized With Return Type MEthod
        {
            int result = a - b;
            return result;
        }
        static void Main(string[] args)
        {
            Program p= new Program();
            p.method(); // Calling Normal Method by using object name

            Program.method1();//Calling Static Method and Static method is called by using class name, we cant call by object naem

            Program.Add(10,20); // Calling pararmeterized constructor 
            Program.Add(100, 220);// 100 and 200 are the Arguments

            Console.WriteLine("Method With Return Type: "+Program.multipli(10, 20)); // Calling Return Type Method
        }
    }
}
