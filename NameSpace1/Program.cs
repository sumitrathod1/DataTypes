using System;
using NameSpace;
using NameSpace1;
using ClassLibrary3;
    using ClassLibrary4;

namespace NameSpace1
{
    public class Program
    {
        class class1:Sumit
        {
           public void print()
            {
                Console.WriteLine(num3);
                Console.WriteLine(num5);
            }
        }
        static void Main(string[] args)
        {
            //NameSpace.Program p=new NameSpace.Program(); // we can call with using fully colified name
            Sumit s=new Sumit();
            s.sss();
            Console.WriteLine(s.num);

            ClassLibrary3.Class1 c=new ClassLibrary3.Class1();// this is a classlibrary
            c.show();

            //p.sss();
        }
    }
}
