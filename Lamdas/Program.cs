using System;

namespace Lamdas
{
    public delegate void myDelegate(int a);
    internal class Program
    {
        static public void myemthod(myDelegate dl,int a)
            {
                 a+=10;
            dl(a);
            }
            
        
        static void Main(string[] args)
        {
            Program.myemthod(delegate (int b) { b += 10; Console.WriteLine(b); },10);
            myDelegate obj = (a) => { Console.WriteLine(a); };
            obj(10);
        }
    }
}
