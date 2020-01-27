using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Thread1
{
    class Threads
    { 
        static void Main(string[] args)
        {
            Console.WriteLine("main starts");
            ThreadClass obj = new ThreadClass();
            Thread th = new Thread(obj.countEven);
            Thread th1 = new Thread(obj.countOdd);
            th.Priority = ThreadPriority.Lowest;
            th1.Priority = ThreadPriority.Highest; 
            th.Start();
            th1.Start();
            Console.ReadLine();


        }


    }
}
