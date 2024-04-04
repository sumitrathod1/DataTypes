using System;
using System.Runtime.CompilerServices;
using static System.Formats.Asn1.AsnWriter;

namespace DataTypes
{
   
    internal class Program
    {
        struct Constr // Struct
        {
            private string x;
            private int y;

            public string Name {
                get { return x; }
                set { x = value; }
            }
            public int ID
            {
                get { return y; }
                set { y = value; }
            }

          public  Constr(String Name, int ID) {
            
                this.x = Name;
                this.y = ID;
            }

            public void printt()
            {
                Console.WriteLine("Name is :" + Name + " ID is : " + ID);
            }

        }

        enum gender  // ENum Class use 
        {
            Unknow,
            Male,
            Female
        }

        class Customers
        {
           public string Name { get; set; }
            public gender gender { get; set; }
        }

        static void Main(string[] args) {

            Customers[] C = new Customers[3];

            C[0] = new Customers
            {
                Name = "Rihan",
                gender = gender.Male
            };
            C[1] = new Customers
            {
                Name = "Lata",
                gender = gender.Female
            };
            C[2] = new Customers
            {
                Name = "LOka",
                gender = gender.Unknow
            };

            foreach (Customers i in C)
            {
                Console.WriteLine("Name is {0} and GEnder is {1}", i.Name, i.gender);
            }

            Constr point = new Constr("AMUl", 2000);

            point.printt();

            //interger data type it can store numbers from -2,147,483,648 to 2,147,483,647.
            int num = 10;
            Console.WriteLine(num);
            long b = num;      // implicit conversion from int to long
            Console.WriteLine(b);
            int c = (int)b; // explicit conversion from long to int
            Console.WriteLine(c);

            // Long Data Type It can store number from -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
            long lng = 5697562136547985632L;
            Console.WriteLine(lng);

            double tlon = lng; //implicit converstion from long to double
            Console.WriteLine("long to double implicitly: " + tlon);
            long tdbl = (long)tlon;//Explicit Conversion from double to long.
            Console.WriteLine("double to long Explicit: " + tdbl);
            float Fltt = lng; //implicit converstion from long to float
            Console.WriteLine("Long to float Implicitly: " + Fltt);
            int d = (int)Fltt; //Explicit Conversion from Float to int.
            Console.WriteLine("floot to int Explicitly: " + d);

            //The Float Data Type
            float flt = 12.25f;
            Console.WriteLine(flt);
            double fl = flt; //implicit converstion from float to double
            Console.WriteLine(fl);


            //Double Data type
            double dbl = 123456789.02D;
            Console.WriteLine(dbl);

            //String Data type
            string Str = "Welcom";
            Console.WriteLine(Str);

            //It compiled into Int
            var N = 10;
            Console.WriteLine("Implicitly converted into INT: " + N);

            //It compiled into String
            var S = "Hello";
            Console.WriteLine("Implicitly converted into String+ " + S);

            //Compiled as an anonymus type
            var ano = new { Name = "Ajay", Age = 20 };

            Console.WriteLine($"{ano.Name} {ano.Age}");

            for (var x = 1; x <= 10; x++) Console.WriteLine(x);


            //type converstion methods
            int K = 122;
            long G = 1254678945621322333;
            char Z = 's';

            Console.WriteLine(Convert.ToBoolean(K));
            Console.WriteLine(Convert.ToInt64(G));
            Console.WriteLine(Convert.ToString(Z));

            ////Arrays with int 

            int[] arr = new[] { 1, 2, 3, 4 };
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }

            //Arrays with String
            string[] city = new string[3];
            city[0] = "Bangalur";
            Console.WriteLine(city[0]);

            //Array without creating new keyword
            string[] Phones = { " Iphone", " One Plus", " Samsung"};

            Console.WriteLine(Phones[1]);

            foreach (string item in Phones)
            {
                Console.Write(item);
            }

            for (int i = 0; i < Phones.Length; i++)
            {
                Console.Write(Phones[i]);
            }

            

            int[,] arr2d = new int[3, 2]{
                                {1, 2},
                                {3, 4},
                                {5, 6}
                            };

            Console.WriteLine(arr2d[0, 0]);
            Console.WriteLine(arr2d[0, 1]);
            Console.WriteLine(arr2d[1, 0]);
            Console.WriteLine(arr2d[1, 1]);
            Console.WriteLine(arr2d[2, 0]);
            Console.WriteLine(arr2d[2, 1]);



        }
    }
}