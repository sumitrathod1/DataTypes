using System;
using System.Diagnostics.CodeAnalysis;

namespace properties
{
    //Properties
    //Properties allow tou to control the accessibilityof a class varibles, and are the rrecommended way to access variables from the outside in c#
    //A property is much like a combination of a variable and a method it cant take any parameters, but you are able to process the valre before its assigned to our returned.
    //Properties are like data fields(Variables), AllowNullAttribute have logic behind them.
    //defined like a field, with "get" and "set" accessors code added.
    //Properties are also used for encapsulation.
    // Types
    // Read/write properties 
    // read/write peroperties 
    // ReadOnly ptoperties
    // write properties
    // auto implemented properties

    internal class Program
    {
        private int std_Id; // Private variables
        private string std_Name;
        private int roll_no=112;
        private int fees;

        public int paisa // Write only property
        {
            set { this.fees = value; }
        }
        public int rollno // Read only Property
        {
            get { return roll_no; }
        }

        

        /// Read and write property
        public int stdId // Setting the property for std_Id
        {
            set
            {
                if (value <= 0)//appliying validation
                {
                    Console.WriteLine("Please enter the correct answar");
                }
                else
                {
                    this.std_Id = value;
                }
            }
            get// getting the property for std_Id
            {
                return std_Id;// Value to Return from Std_Id
            }
        }

        public string  stdName
        {
            set// Setting the property for std_Name
            {
                this.std_Name = value;// Value to set Std_Name
            }
            get // getting the property for std_Name
            { 
                return std_Name;// Value to Return from Std_Name
            }
        }

        public string FName { get; set; }
        private string LName { get; set; }

        public Program(string pnam, string anam)
        {
            this.FName = pnam;
            this.LName=anam;

            Console.WriteLine("First name {0} And Last Name {1} called with the help of propeties and constructor",FName,LName);
        }
        static void Main(string[] args)
        {
            Program p = new Program("Ankush","Bhatiya");
            p.stdId = 10; // set the value
            p.stdName = "Arun";//get the value
            Console.WriteLine((p.stdId));
            Console.WriteLine(p.std_Name);

            p.paisa = 10000; // Only Write Set Only
            // Console.WriteLine(p.fee); // write only we cant access this 
            Console.WriteLine(p.roll_no); //Read only 
        }
    }
}
