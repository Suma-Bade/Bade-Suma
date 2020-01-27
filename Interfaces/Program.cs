using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            ICICI chn = new ICICI("ICICI 001","Chennai","Rama");
            SBI hyd = new SBI("SBI009", "hyderabad", "sita");
            chn.displayDetails();
            chn.getInterest();
            hyd.displayDetails();
            hyd.getInterest();
            Console.ReadLine();
        }
    }
}
