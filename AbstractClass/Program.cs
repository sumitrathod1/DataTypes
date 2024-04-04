using System;

namespace AbstractClass
{
    internal class Program
    {
       public abstract class Detail
        {
            public string Name;
            public string LastName;
            public int age;
            public string City;

           public abstract void show();
        }

        public class student : Detail
        {
            public int roll_no;
            public int marks;

            public override void show()
            {
                Console.WriteLine("Student name is: "+ Name);
                Console.WriteLine("Student Last Name is "+ LastName);
                Console.WriteLine("Student Age is "+age);
                Console.WriteLine("Student City is "+City);
                Console.WriteLine("Stdent Roll No is "+ roll_no);
                Console.WriteLine("Student Marks is"+ marks);
                
            }
        }

        public class Teacher : Detail
        {
            public string Ocupation;
            public int Salary;

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
            s.Name = "Arnav";
            s.age = 15;
            s.roll_no = 05;
            s.marks = 50;
            s.LastName = "Sighn";
            s.City = "Bangalur";
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
