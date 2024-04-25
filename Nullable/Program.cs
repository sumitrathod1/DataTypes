using System;

namespace Nullables
{
    internal class Program
    {
        
        static void Main(string[] args)
        {

            int? ak = null;
            if (ak == null)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("no");
            }

            int? ER=null;
           int KK = ER ?? 0;

            Console.WriteLine(KK);

            int? r = 0;
            int? s = null;
            int a = s ?? 20;
            int? m = 26;
            Nullable<int> n = null;
            int k = 0;

            Console.WriteLine(s);
            Console.WriteLine(a);
            Console.WriteLine(n.GetValueOrDefault());
            Console.WriteLine(m.GetValueOrDefault());
            Console.WriteLine(s.HasValue);
            Console.WriteLine(m.HasValue);

            if (Nullable.Compare<int>(n, r) < 0)
            {
                Console.WriteLine("less");
            }
            else
            {
                Console.WriteLine("greater");
            }
        }
    }
}
