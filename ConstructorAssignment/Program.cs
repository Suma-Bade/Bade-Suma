using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAssignment
{
    class Accounts
    {
        int accNo;
        static string bName;
        string name, accType, transType;
        int amount, balance;
        public int AccNo
        {
            get
            {
                return accNo;
            }
            set
            {
                accNo = value;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string AccType
        {
            get
            {
                return accType;
            }
            set
            {
                accType = value;
            }
        }
        public string TransType
        {
            get
            {
                return transType;
            }
            set
            {
                transType = value;
            }
        }
        public int Amount
        {
            get
            {
                return amount;
            }
            set
            {
                amount = value;
            }
        }
        static Accounts()//static constructor used to initialise static members
        {
            bName = "SBI";
        }
        public Accounts(int accNo, string name, string accType, string transType)
        {
            
            this.accNo = accNo;
            this.name = name;
            this.accType = accType;
            this.transType = transType;

        }
        public int Credit(int amn)
        {
            int res = amount + amn;
            return res;

        }
        public int Debit(int amo)
        {
            int result = amount - amo;
            return result;
        }
        public void display()
        {
            Console.WriteLine("Name= " + Name + "\nAccNo= " + AccNo + "\nAccType= " + AccType+"\nAmount="+Amount);
        }
        static void Main(string[] args)
        {
            Accounts a = new Accounts();
            a.Name="Suma";
            a.AccNo=1234567899;
            a.AccType = "savings";
            a.Amount = 2300;
           
            a.display();
            Console.WriteLine("enter d or w");
            string transType = Console.ReadLine();
            if(transType=="d")
            {
                Console.WriteLine("enter amount to credit");
                int c = int.Parse(Console.ReadLine());
                Console.WriteLine("balance after credit="+a.Credit(c));
            }
            else
            {
                Console.WriteLine("enter amount to debit");
                int d = int.Parse(Console.ReadLine());
                Console.WriteLine("balance after debit=" + a.Debit (d));
            }


            Console.ReadKey();

        }
    }
}
