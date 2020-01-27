using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            //A obj1 = new A();
            //obj1.display();
            //B obj2 = new B();
            //obj2.display();
            //C obj3 = new C();
            //obj3.display();

            A obj = new A();
            obj.display();
            obj = new B();
            obj.display();
             obj= new C();
            obj.display();









            //Shape picture = new Shape();
            //picture.draw();
            //picture.draw(10);
            //picture.draw(10, 20);
            //picture.draw(10, 20, 30);
            Console.ReadLine();
        }
    }
}
