﻿using System;

namespace interfaceee
{
    internal class Program
    {
        class B
        {
            public int a;
            public int b;


            public B(int m,int r)
            {
                this.a = m;
                this.b = r;
            }
        }

        class A
        {
            public int j;
            public int k;
            public B c;

            public A(int l,int n,B h)
            {
                this.j = l;
                this.k = n;
                c = h;
            }
            public void print()
            {
                Console.WriteLine(j+" "+k+" "+c.a);
            }
        }
    static void Main(string[] args)
        {
            B b= new B(20,50);
            A a = new A(16,15,b);
            Program p = new Program();

            a.print();

            Console.WriteLine("Hello World!");
        }
    }
}
