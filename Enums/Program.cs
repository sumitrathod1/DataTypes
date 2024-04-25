using System;

namespace Enums
{
    // Enums are special class  that represents the group of constatnts (unchangable or readonly)
    // We can create Enums in namesapce also  
    enum day
    {
        monday = 1,// We can set the Enum index value 
        twesday,
        wednasday,
        thursday,
        friday,
        saturday,
        sunday,
    }
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine(day.friday);
            int val = (int)day.friday;// Enum explicit convertion. We Canont convert implicit convertion of enums
            Console.WriteLine( val);

            day myday = day.sunday;
            int nday = (int)day.friday;

            Console.WriteLine(nday);

            switch (myday)// we can use enums in switch cases
            {
                case day.monday:
                    Console.WriteLine("Hello Iam monday");
                    break;
                case day.twesday:
                    Console.WriteLine("Hello Iam twesday");
                    break;
                case day.wednasday:
                    Console.WriteLine("Hello Iam wednasday");
                    break;
                case day.thursday:
                    Console.WriteLine("Hello Iam thursday");
                    break;
                case day.friday:
                    Console.WriteLine("Hello Iam friday");
                    break;
                case day.saturday:
                    Console.WriteLine("Hello Iam satrday");
                    break;
                case day.sunday:
                    Console.WriteLine("Hello Iam sunday");
                    break;
                default:
                    Console.WriteLine("invalid day");
                    break;
            }

        }
    }
}
