using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    interface Iloan
    {
         void getInterest();//public by default
    }
    interface IGloan:Iloan//interface supports inheritance
    {
        void getGoldInterest();
    }
    interface IDmat
    {
        void displayDemat();
    }
  public abstract class Bank
    {
        protected string bName;
        protected string location;
        public Bank(string bname,string location)
        {
            this.bName = bname;
            this.location = location;
        }
    }
    public class SBI:Bank,IGloan
    {
        string bManager;
        public SBI(string bname,string location,string bmanager):base(bname,location)
        {
            this.bManager = bmanager;
        }
        public void getInterest()
        {
            Console.WriteLine("SBI loan interset is 10%");
        }
        public void getGoldInterest()
        {
            Console.WriteLine("SBI gols loan intrest is 12%");
        }
        public void displayDetails()
        {
            Console.WriteLine(this.bName + " " + this.location + " " + this.bManager);
        }

    }
    public class ICICI : Bank,Iloan,IDmat
    {
        string bHead;
        public ICICI(string bname, string location, string bmanager) : base(bname, location)
        {
            this.bHead = bmanager;
        }
        public void displayDemat()
        {
            Console.WriteLine("ICICI can start demat accounts");
        }
        public void getInterest()
        {
            Console.WriteLine("ICICI loan interset is 17%");
        }
        public void displayDetails()
        {
            Console.WriteLine(this.bName + " " + this.location + " " + this.bHead);
        }

    }
}
