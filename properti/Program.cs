using System;
using System.Text;

namespace properti
{
    class BankAccount
    {
        private decimal balance;
        public BankAccount(decimal initialamount)
        {
            balance =  initialamount;
        }

        public void deposit(decimal amount)
        {
            balance = balance + amount;
        }
        public void withdrawl(decimal amount)
        {
            if(balance >= amount)
            {
                balance= balance- amount;
            }
            else
            {
                Console.WriteLine("Insuficent balance");
            }
        }
        public decimal getbalance() { return balance; }
    }
    internal class Program
    {
        private string name;
        private int age;
        private int marks=35;
        //Read Only Properties
        public int StMarks 
        {
            get
            {
                return marks;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public int Age 
        {
            get
            {
                return age;
            }
            set
            {
                age= value;
            }
        }

        //Read Only Properties
        private static int month;
        Program()
        {
            month++;
        }
        public static int mon
        {
            get {
                return month;
            }
        }
        // Static Class :- Static class contain only static data members and methods, we canot create a constructor of statice class
        static class B 
        {
          public static int M=10;
           static string U = "PRoduct";

           public static void bir()
            {
                Console.WriteLine(M);
                Console.WriteLine(U);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Program p = new Program();
            Program p1 = new Program();
            B.M = 12;
            B.bir();

            BankAccount myaccount = new BankAccount(1000);
            myaccount.deposit(500);
            myaccount.deposit(1000);
            Console.WriteLine("Balance is " + myaccount.getbalance());

            myaccount.withdrawl(2000);
            Console.WriteLine("Account balnace is : "+ myaccount.getbalance() );

            p.Name = "Rahul";
            p.Age = 25;

            Console.WriteLine("Sutudent Name = {0} And Student Age = {1} Marks = {2}" ,p.name,p.Age,p.marks );

            //int[] A = new int[5];

            //for (int i = 0; i < A.GetLength(0); i++)
            //{
            //    A[i] = Convert.ToInt32(Console.ReadLine());
            //}

            //for (int i = 0; i <A.GetLength(0) ; i++)
            //{
            //    Console.WriteLine(A[i]);
            //}


            //int[,] twd = new int[2,3];

            //for (int i = 0; i < twd.GetLength(0); i++)
            //{
            //    for (int j = 0; j < twd.GetLength(1); j++)
            //    {
            //        twd[i, j] = Convert.ToInt32(Console.ReadLine());
            //    }
            //}

            //for (int i = 0; i < twd.GetLength(0); i++)
            //{
            //    for (int j = 0; j <twd.GetLength(1); j++)
            //    {
            //        Console.Write(twd[i,j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            //int[,,] thr = new int[2, 2, 3];

            //for (int i = 0; i < thr.GetLength(0); i++)
            //{
            //    for (int j = 0; j <thr.GetLength(1); j++)
            //    {
            //        for (int k= 0; k <thr.GetLength(2); k++)
            //        {
            //            thr[i, j, k] = Convert.ToInt32(Console.ReadLine());
            //        }
            //    }
            //}

            //for (int i = 0; i < thr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < thr.GetLength(1); j++)
            //    {
            //        for (int k = 0; k < thr.GetLength(2); k++)
            //        {
            //            Console.Write(thr[i,j,k]+ " ");
            //        }
            //        Console.WriteLine();
            //    }
            //    Console.WriteLine();
            //}

            Console.Write("Enter your Name : ");

            StringBuilder enter =new StringBuilder( Console.ReadLine());
            enter.AppendLine(" milk");
            enter.Append(" india");
            enter.Replace(" milk"," dudh");
            enter.Replace("india", "pita hai india");
              
            Console.WriteLine(enter);
        }
    }
}
