using System;
using System.Linq;

namespace linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] age = {10, 20, 13, 18, 16, 19, 20, 23, 24, 25, 26};

            var a = from i in age where i > 18 orderby i descending select i;
            foreach (int i in a)
            {
                Console.WriteLine(i);
            };

            string[] names = {"anil","kiran","rakesh","navin","sumit","krunal" };

            var s = from name in names where name.Contains("s") select name;

            foreach (string item in s)
            {
                Console.WriteLine(item);
            }

            


        }
    }
}
