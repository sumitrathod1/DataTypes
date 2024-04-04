using System;

namespace Arrays
{
    internal class Program
    {
        // created arrays 
        int[] a = new int[5];
        void show()
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
        }
    }
}
