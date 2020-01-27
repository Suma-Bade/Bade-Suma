using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thread1
{
    class ThreadClass
    {
        public void countEven()
        {
            for(int i=0;i<100;i+=2)
            {
                Console.WriteLine(i);
                
            }
        }
        public void countOdd()
        {
            for (int i = 1; i < 100; i += 2)
            {
                Console.WriteLine(i);
            }

        }
       
    }
}
