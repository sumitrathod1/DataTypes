using System;

namespace Constructors
{
    internal class Program
    {
        public Program() // Default Constructor we can create only one default constructor
        {
            Console.WriteLine("This is Default Constructor");
        }

        // We can create multiple constructor with a differnt signatures
        public Program(int a, int b)// Constructor overloading withe the diffrent signiture
        {
            Console.WriteLine("This is Constructor with overloded, Addition of numbers {0} ",a+b);
        }

        public string stdName;
        public int stdAge;
        public int StdClass;
       
        public Program(int SClass,string sName,int sAge)//Parameterized constructor
        {
            this.StdClass = SClass;
            this.stdName=sName;
            this.stdAge=sAge;
            Console.WriteLine("I am  Parameterized constructor");
        }

        public Program(Program p) // Copy Constructor 
        {
            StdClass = p.StdClass;
            stdName = p.stdName;
            stdAge = p.stdAge;
        }

        public void getstd()
        {
            Console.Write("hi I am \"{0}\"",stdName);
            Console.Write(" and my age is \"{0}\"", stdAge);
            Console.WriteLine(" i am in \"{0}\" year ", StdClass);
        }
        public Program(string Name, int age) //Constructor Overloading with a differnt data types
        {
            Console.WriteLine("This is a Constructor overloading With Different dataType age is integer type \"{0}\" and Name is String type \"{1}\"",age,Name);
        }

        class PC
        {
           public PC(string PCName,int Price)// parameterized constructor
            {
                Console.WriteLine("Pc Name is {0} and Price is {1} \"This is a Parameterized constructor\"",PCName,Price);
            }

            public static int Age;
            public static string Name;
            static PC()// Static Constructor
            {
                int Age=30;
                string Name="Rahul";
                Console.WriteLine("This is a Static Constructor, Only one Static constructor is created in one class");
            }

            public static void getDetail() //Static Method
            {
                Console.WriteLine("Age {0}", Age);
                Console.WriteLine("Name {0}", Name);
            }
        }

        class priva 
        {
            public static int A;

            //Private constructor , we use private constructor to protect our class we canot inhetr this class
            // And we cannot create a object of this class
            private priva()
            {

            }

            public static int getValue()
            {
                return ++A;
            }


        }

        static void Main(string[] args)
        {
            Program p=new Program(); // Default Constructor Calls Automaticaly when we create the object of the class
            Console.WriteLine();
            Program p2=new Program(1,2);// This is a same constructor with a different signature 
            Console.WriteLine();
            Program p3=new Program("Kamlesh",22);// This is overloaded Constructor with a differnt data types
            Console.WriteLine();
            Program pp=new Program(1,"Arun",23);
            pp.getstd();
            Console.WriteLine();

            Program pp1 = new Program(pp);
            pp1.getstd();
            Console.WriteLine("------------------------------------------------------------------------------------");
           
            Console.WriteLine();
            
            PC pc = new PC("Lenovo",60000); // We have to give the attributes when we create a parameterized constructor
            PC.getDetail(); // Static Methods can be called by Class name only

            Console.WriteLine();

            Console.WriteLine("-------------------------------------------------------------------------------------");
            priva.A = 10;
            Console.WriteLine(priva.getValue());
        }
    }
}
