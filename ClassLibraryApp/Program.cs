using ClassLibrary4;
using System;

namespace ClassLibraryApp
{
    static class As
    {
       public static void log(this Class1 ob)
        {
            Console.WriteLine("log");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
          ClassLibrary3.Class1 c=new ClassLibrary3.Class1();
          Console.WriteLine(c.cla);
          c.show();
          ClassLibrary4.Class1 c2=new ClassLibrary4.Class1();
          c2.print();
          c2.b = 20;
            c2.log();
        }
    }
}
