using System;
using System.Diagnostics;

namespace AbstractClass
{
    //Abstract classes are used to declare common characteristics of sbclasses,
    // A class which contains the abstract keyword in its declaration is know as abstract class
    //it can onlye be used as Base class for other classes that extend the abstract class.
    //If the class contain at least one abstract than the class must be declared abstract class
    // If class is declared abstrac than that class cannot be instantiated
    internal class Program
    {
       public abstract class Detail
        {
            public string Name;
            public string LastName;
            public int age;
            public string City;

            private int j;
            private int k;

            public int gg
            {
                set { j = value; }
                get { return j; }
            }
            public int cc
            {
                set { k = value; }
                get { return k; }
            }

            public abstract string bagName { set; get; }
            public abstract int bagPrice { set; get; }

            public abstract void show();
        }

        public class student : Detail
        {
            private string Bag;
            private int Price;
            public int roll_no;
            public int marks;

            public override string bagName 
            {
                set { Bag = value; }
                get { return Bag; }
            }
            public override int bagPrice
            {
                set { Price = value; }
                get { return Price; }

            }

            public override void show()
            {
                Console.WriteLine("Student name is: "+ Name);
                Console.WriteLine("Student Last Name is "+ LastName);
                Console.WriteLine("Student Age is "+age);
                Console.WriteLine("Student City is "+City);
                Console.WriteLine("Stdent Roll No is "+ roll_no);
                Console.WriteLine("Student Marks is"+ marks);
                Console.WriteLine();
                Console.WriteLine("Bag is : "+bagName);
                Console.WriteLine("Bag price is : "+bagPrice);

                int result = gg + cc;
                Console.WriteLine();
                Console.WriteLine(result);
                
            }
        }

        public class Teacher : Detail
        {
            private string Bag;
            private int Price;
            public string Ocupation;
            public int Salary;

            public override string bagName
            {
                set { Bag = value; }
                get { return Bag; }
            }
            public override int bagPrice
            {
                set { Price = value; }
                get { return Price; }

            }
            public override void show()
            {
                Console.WriteLine($"teacher name is: {Name} {LastName}");
                Console.WriteLine($"teacher age is: {age}");
                Console.WriteLine($"teacher City is: {City}");
                Console.WriteLine($"teacher Ocupation is: {Ocupation}");
                Console.WriteLine($"teacher salary is: {Salary}");

            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Student details");
            Console.WriteLine();
            student s=new student();
            s.bagName = "Lenovo";
            s.bagPrice = 50000;
            s.Name = "Arnav";
            s.age = 15;
            s.roll_no = 05;
            s.marks = 50;
            s.LastName = "Sighn";
            s.City = "Bangalur";
            s.gg = 12;
            s.cc = 12;
            s.show();
            Console.WriteLine();
            Console.WriteLine("Teacher details");
            Console.WriteLine();
            Teacher t = new Teacher();
            t.Name = "Kamal";
            t.age = 26;
            t.LastName = "Sha";
            t.City = "Vadodara";
            t.Salary = 200000;
            t.Ocupation = "BBA";
            t.show();
        }
    }
}
