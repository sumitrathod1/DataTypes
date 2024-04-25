using System;
using System.Runtime.Intrinsics.Arm;
using teamA.teamB;

namespace Indexers
{
    internal class Program
    {
        private int[] Name = new int[4];
        
        public int this[int index] 
        {
            set 
            {
                Name[index] = value;
            }
            get
            {
                return Name[index];
            }
        } 
        static void Main(string[] args)
        {
            teamA.teA tA=new teamA.teA();
            tA.show();

            Program p = new Program();
            p[0] = Convert.ToInt32(Console.ReadLine());
            p[1] = Convert.ToInt32(Console.ReadLine());
            p[2] = Convert.ToInt32(Console.ReadLine());
            p[3] = Convert.ToInt32(Console.ReadLine());

            

            Console.WriteLine(p[0]);

            Console.WriteLine(p[1]);

            Console.WriteLine(p[2]);

            Console.WriteLine(p[3]);
            Console.ReadLine();
        }
    }
}

namespace teamA
{
    namespace teamB
    {
        class teB
        {
            public void print()
            {
                Console.WriteLine("hii I am TeB");
            }
        }
    }
    class teA
    {
        public void show()
        {
            Console.WriteLine("hii team TeA");
        }
    }

}