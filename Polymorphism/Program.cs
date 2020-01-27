using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Shape
    {
        int length;
        int breadth;
        int width;
        public void draw()
        {
            Console.WriteLine("A shape can be drawn");
        }
        public void draw(int l)
        {
            this.length = l;
            Console.WriteLine("A square can be drawn");
        }
        public void draw(int l,int b)
        {

            Console.WriteLine("A rectangle can be drawn");
        }
        public void draw(int l,int b,int w)
        {
            Console.WriteLine("A box can be drawn");
        }

    }
}
