using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class inheritance
    {
        static void Main(string[] args)
        {
            //Vehicle veh = new Vehicle();
            Car alto = new Car("black",120,"premium");
            Bus volvo = new Bus();
           // veh.start();
            //veh.stop();
            alto.start();
            alto.Drive();
            alto.fillfuel();
            alto.stop();
            volvo.start();
            volvo.fillfuel();
            volvo.Run();
            volvo.stop();
            //Parent pObj = new Parent();
            //Child obj = new Child();
            //GrandChild gObj = new GrandChild();
            //pObj.getValues(12, " cts");
            //pObj.display();
            //obj.getValues(23, " C#");
            //obj.display();
            //obj.Calculate(12);
            //gObj.getValues(10, "  ASP.Net");
            //gObj.display();
            //gObj.Calculate(20);
            //gObj.multiply(10);
            Console.ReadLine();
        }
    }
}
