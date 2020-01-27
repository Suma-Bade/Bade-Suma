using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstanceAss
{
   public abstract class Student
    {
       protected int id;
       protected string name;
       protected double examFee;
        public Student(int id,string name,double examfee)
        {
            this.id = id;
            this.name = name;
            this.examFee = examfee;
        }
        public void displayDetails()
        {
            Console.WriteLine("Student id is" + this.id + "with name" + this.name + "and the examfee is" + this.examFee);
        }
        public double payFee()
        {
            Console.WriteLine("You should pay a fee of " + this.examFee);
            return payFee();
        }

    }
    public class DayScholar : Student
    {
        double transportFee;
        public DayScholar(int id, string name, double examfee,double transportFee):base(id,name,examfee)
        {
            this.transportFee = transportFee;
        }
        public void displayDetails()
        {
            Console.WriteLine("Student id is" + this.id + "with name" + this.name + "and the examfee is" + this.examFee+"and transport fee"+this.transportFee);
        }
        public double payFee(double totalFee)
        {
            totalFee = examFee + transportFee;
            Console.WriteLine("You should pay a fee of " + totalFee);
            return payFee();
        }

    }
    public class Hosteler : Student
    {
        double hstlFee;
        public Hosteler(int id, string name, double examfee, double hstlFee) : base(id, name, examfee)
        {
            this.hstlFee = hstlFee;
        }
        public void displayDetails()
        {
            Console.WriteLine("Student id is" + this.id + "with name" + this.name + "and the examfee is" + this.examFee + "and hstl fee" + this.hstlFee);
        }
        public double payFee(double totalFee)
        {
            totalFee = examFee + hstlFee;
            Console.WriteLine("You should pay a fee of " + totalFee);
            return payFee();
        }

    }
}
