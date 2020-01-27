using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class A
    {
        public virtual   void display()
        {
            Console.WriteLine("display class A details");
        }
    }
    class B:A
    {
        public override void display()
        {
            Console.WriteLine("display class B details");
        }
    }
    class C:A
    {
        public override void display()
        {
            Console.WriteLine("display class C details");
        }
    }

}
