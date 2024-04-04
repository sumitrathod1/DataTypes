using System;
using System.Runtime.Intrinsics.X86;
using System.Text;

namespace StringsAndArrays
{
    internal class Program
    {

        private int age;
        private string name;

        public int Age { get { return age; } set { age = value; } }
        public string Name { get { return name; } set { name=value; } }
       
        public void show()
        {
            Console.WriteLine(age);
            Console.WriteLine(name);
        }


        static void Main(string[] args)
        {
            Program p = new Program();
            p.Age = 26;
            p.Name = "arun";
            p.show();

            //Strings
            string FirstName = "Vinod";
            Console.WriteLine(FirstName);

            //using char array to convert string
            char[] FName = { 'H', 'E', 'L', 'L', 'O' };

            string str = new string(FName);

            Console.WriteLine(str);

            //Use oF special Charectores in string
            string samp = "I'am good! \"How are you\"";
            Console.WriteLine(samp);

            //Use of Verbatim Strings
            string verb = @"c#:\program is Good";
            Console.WriteLine(verb);
            //We can use double Quotes in Verbatim like this
            string verb2 = @"Hello ""Wlecome"" Home";
            Console.WriteLine(verb2);

            // We can use newline in the same string  
            string newline = "C# \n" + "And \n" + "Dot Net both are\n" + "Same";
            Console.WriteLine(newline);

            // String Conecctions 
            String LastName = "Patel";
            LastName = "Sha";
            String conetcs = "Mr " + FirstName + " " + LastName;
            Console.WriteLine(conetcs);

            //Another way with the help of string interpolution
            string interp = $"Mr {FirstName} {LastName}";
            Console.WriteLine(interp);

            // Getting user inputs
            Console.Write("Enter username:");
            //string userName = Console.ReadLine();

            //Console.WriteLine("Username is: " + userName);

            Console.Write("Enter your age: \n");
            //int age = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Your age is: " + age);

            // StringBuilder 
            StringBuilder st = new StringBuilder("Hello");
            st.Append(" Sir"); //to concatinate the value
            st.Insert(9, " 22"); // to insert the value in the middle of the sting we insert
            st.Replace("22", " Thank you");
            st.Append(" How are you");
            st.AppendLine(" Sir");
            st.AppendLine(" book");
            string ste=st.ToString();//converted into string
            Console.WriteLine(ste);
            ste = "kk";

            Console.WriteLine(ste);
            Console.WriteLine(st);

            StringBuilder sbl = new StringBuilder("Amount is :");
            sbl.AppendFormat("{0} ", 20);
            Console.WriteLine(sbl);

            StringBuilder sb = new StringBuilder("Hello World!");
            Console.WriteLine(sb);
            for (int i = 0; i < sb.Length; i++)
                Console.Write(sb[i]);

             //tringBuilder is mutable.
             //StringBuilder performs faster than string when appending multiple string values.
             //Use StringBuilder when you need to append more than three or four strings.
             //Use the Append() method to add or append strings to the StringBuilder object.
             //Use the ToString() method to retrieve a string from the StringBuilder object.
        }
    }
}
