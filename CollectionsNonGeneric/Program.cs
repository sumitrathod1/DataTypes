using System;
using System.Collections;

namespace CollectionsNonGeneric
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ArrayList can Stores Objects of any type like an array
            //in arraylist there is no need to specify the size of the ArrayList
            ArrayList city = new ArrayList()
            {
                "Bangalore",
                "Hydrabad",
                "Vadodara",
                "Ahemdabad",
                10
            };

            for (int i = 0; i < city.Count; i++)
            {
                Console.WriteLine(city[i]);
            }

            Console.WriteLine();    
            //HashTable
            //In HashTable we can store the data in key value pairs
            //and we can get the data through the key 
            Hashtable employedetail = new Hashtable()
            {
                {"Id",12345 },
                {"name","kiran" },
                {"department","IT" }
            };

            employedetail.Add("LastName","nidhi");


            Console.WriteLine(employedetail["Id"]);
            foreach (DictionaryEntry entry in employedetail)
            {
                Console.WriteLine(entry.Key + ": " + entry.Value);
            }

            Console.WriteLine("------------------------------------------------------");

            //Stack
            //stack are used to store the data following the LIFO (Last in First Out) concept
            Stack student = new Stack();
            student.Push("deep");
            student.Push(1);
            student.Push(".net");

            foreach (var item in student)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine( );

            student.Pop();

            foreach (var item in student)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-----------------------------------------------------------");

            //Queue 
            //Queues are used to store data following the FIFO (First-In-First-Out) concept.

            Queue myQueue= new Queue();
            myQueue.Enqueue(1);
            myQueue.Enqueue("Sahil");
            myQueue.Enqueue("Dharavya");

            foreach (var item in myQueue)
            {
                Console.WriteLine(item);
            }
            myQueue.Dequeue();

            foreach (var item in myQueue)
            {
                Console.WriteLine(item);
            }

        }
    }
}
