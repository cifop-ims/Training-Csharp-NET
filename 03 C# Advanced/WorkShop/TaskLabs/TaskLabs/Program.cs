using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _01_Getting_Started_With_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            //create task object and pass anonymous method 
            //to task constructor parameter as work to do 
            //within the task
            //Task t = new Task(() =>
            //{
            //    for (int i = 0; i < 100; i++)
            //    {
            //        //print task t thread id
            //        var threadId = Thread.CurrentThread.ManagedThreadId;
            //        Console.WriteLine("Task Loop Current Thread Id:" + threadId);
            //    }
            //});

            ////start task t execution
            //t.Start();

            //for (int i = 0; i < 100; i++)
            //{
            //    //print main thread id
            //    var threadId = Thread.CurrentThread.ManagedThreadId;
            //    Console.WriteLine("Main Loop Current Thread Id " + threadId);
            //}

            ////wait for task t to complete its execution
            //t.Wait();

            //Console.WriteLine("Press enter terminate the process!");
            //Console.ReadLine();
            List<string> fruits = new List<string>();
            fruits.Add("Apple");
            fruits.Add("Banana");
            fruits.Add("Bilberry");
            fruits.Add("Blackberry");
            fruits.Add("Blackcurrant");
            fruits.Add("Blueberry");
            fruits.Add("Cherry");
            fruits.Add("Coconut");
            fruits.Add("Cranberry");
            fruits.Add("Date");
            fruits.Add("Fig");
            fruits.Add("Grape");
            fruits.Add("Guava");
            fruits.Add("Jack-fruit");
            fruits.Add("Kiwi fruit");
            fruits.Add("Lemon");
            fruits.Add("Lime");
            fruits.Add("Lychee");
            fruits.Add("Mango");
            fruits.Add("Melon");
            fruits.Add("Olive");
            fruits.Add("Orange");
            fruits.Add("Papaya");
            fruits.Add("Plum");
            fruits.Add("Pineapple");
            fruits.Add("Pomegranate");

            Console.WriteLine("Printing list using foreach loop\n");

            var stopWatch = Stopwatch.StartNew();
            foreach (string fruit in fruits)
            {
                Console.WriteLine("Fruit Name: {0}, Thread Id= {1}", fruit, Thread.CurrentThread.ManagedThreadId);
            }
            Console.WriteLine("foreach loop execution time = {0} seconds\n", stopWatch.Elapsed.TotalSeconds);
            Console.WriteLine("Printing list using Parallel.ForEach");


            stopWatch = Stopwatch.StartNew();
            Parallel.ForEach(fruits, fruit =>
            {
                Console.WriteLine("Fruit Name: {0}, Thread Id= {1}", fruit, Thread.CurrentThread.ManagedThreadId);

            }
            );
            Console.WriteLine("Parallel.ForEach() execution time = {0} seconds", stopWatch.Elapsed.TotalSeconds);
            Console.Read();
        }
    }
}