using System;
using System.Collections;
using System.Collections.Generic;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
           List<int> num=new List<int>();
            num.Add(1);
            num.Add(2);
            num.Add(3);
            num.Add(4);

            ArrayList arr = new ArrayList()
            {
                2,"Amul",20,"Vadodar"
            };

            for (int i = 0; i < arr.Count; i++)
            {
                Console.WriteLine(arr[i]);
            }

            for (int i = 0; i < num.Count; i++)
            {
                Console.WriteLine(num[i]);
            }
        }
    }
}
