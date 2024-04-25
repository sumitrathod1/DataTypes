using System;

namespace Arrays
{
    public class Program
    {
        // Array is 
        // created arrays 
        int[] a = new int[5];
       public void show()
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
        }

        // creating arrays with declaration and initialization 
        int[] b=new int[5] {10,20,30,40,50};

        //3rd way to create arrays
        int[] c = { 100, 200, 300, 400, 500 };

        public void see(params int[] val)
        {
            for (int i = 0; i < val.Length; i++)
            {
                Console.WriteLine(val[i]);
            }
        }
        public void sss()
        {
            Console.WriteLine("namespace");
        }
        static void Main(string[] args)
        {
            Program p= new Program();
            p.a[0] = 1;
            p.a[1] = 2;
            p.a[2] = 3;
            p.a[3] = 4;
            p.a[4] = 5;
            p.show();
            p.see(1,2,3,4,5);

            for (int i = 0; i < p.b.Length; i++)
            {
                Console.WriteLine(p.b[i]);
            }
            for (int i = 0; i < p.c.Length; i++)
            {
                Console.WriteLine(p.c[i]);
            }

            // 2d Arrays 
            int[,] a = new int[2, 3];

            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j]= Convert.ToInt32(Console.ReadLine());
                }
            }

            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(a[i,j]);
                }
                Console.WriteLine();
            }

            //jugged array
            int[][] jag = new int[3][];
            jag[0] = new int[] { 1, 2, 3, 4, 5, 6 };
            jag[1] = new int[] { 2, 3, 4 };
            jag[2] = new int[] { 5, 6 };

            for (int i = 0; i < jag.Length; i++)
            {
                for (int j = 0; j < jag[i].Length; j++)
                {
                    Console.Write(jag[i][j]);
                }
                
                
                Console.WriteLine();
            }

        }
    }
}
