using System;

namespace Structs
{
    internal class Program
    {
        // Struct are same as a class, structs are value types and class are reference type 
        //we cannot create a default constructor in structs (it has already constructed by default)
        //we can create a argumented construtor in structs
        //we can create autoimplemented properties
        //we cannot assighn a value in structs
        //Structs cannot inherit from other structs or classes but can inherit interfaces.
        // it can only inherites interface
        //Structs can have instance members like fields, properties, and methods


        public interface student //Structs can implement interfaces
        {
         void show();


            string fname { set; get; } 
        }
       public struct Std:student
        {
           public string firstname;
            public string fname  //we can create autoimplemented properties
            {
                set;
                get;
            }

            int x;
            int z;
          public Std(int l,int m)
            {
                this.x = l;
                this.z = m;
                Console.WriteLine(l*m);
            }

            public int num1;
            public int num2;
            public string name;

            int a;
            int b;
            public int number
            {
                set { a = value; }
                get { return num1; }
            }
            public int number2
            {
                set { b = value; }
                get { return num1; }
            }

            public void show()
            {
                Console.WriteLine(num1+num2+" "+name);
                Console.WriteLine(a+b);
                Console.WriteLine(firstname);
                Console.WriteLine(fname);
            }
        }

        static void Main(string[] args)
        {
            Std s=new Std(100,200);
            s.num1 = 10;
            s.num2 = 30;
            s.name = "Addition";
            s.number = 1;
            s.number2 = 2;
            s.firstname = "Akash";
            s.fname = "Rahul";
            s.show();
        }
    }
}
