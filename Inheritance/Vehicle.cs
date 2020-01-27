using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
   abstract class Vehicle
    {
        protected string color;
        public Vehicle()//parent default constructor invoke automatically for all child objects
        {
            this.color = "white";
            Console.WriteLine("Constructor from vehicle");
        }
        public Vehicle(string clr)//parent parameterised constructor has to be invoked using base keyword 
        {
            this.color = clr;
            Console.WriteLine("parameterised constructor");
        }
        public abstract void fillfuel();//child sholud compulsory overide
       public virtual void start()//child may or may not override
        {
            Console.WriteLine("vehicle started");
        }
        public void stop()
        {
            Console.WriteLine("vehicle stopped");
        }
    }
    class Bus:Vehicle
    {
        int seating;
        int speed;
        public Bus():base("Red")
        {
            this.seating = 90;
            this.speed = 120;
            Console.WriteLine("Constructor from bus");
        }
        public override void fillfuel()
        {
            Console.WriteLine("filled diesel");
        }
        public void Run()
        {
            Console.WriteLine(this.color+" bus is runing at speed "+this.speed+" with "+this.seating+" passengers");
        }
        

    }
    class Car:Vehicle
    {
        int speed;
        string type;
        public Car()
        {
            this.speed = 200;
            this.type = "standard";
            Console.WriteLine("Constructor from car");
        }
        public Car(string colr,int spd,string type):base(colr)
        {
            this.speed = spd;
            this.type = type;
        }
        public override void fillfuel()
        {
            Console.WriteLine("filled diesel/petrol/gas");
        }
        public void Drive()
        {
            Console.WriteLine(this.color+" car is driving at speed " + this.speed + " with " + this.type );
        }
    }
}
