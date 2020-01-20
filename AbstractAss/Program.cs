using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractAss
{
  public  abstract  class Student
    {
       protected string name;
        protected int studentId;
        protected int grade;
        public abstract Boolean Ispassed(int grade);

    }
    public class Undergrad:Student
    {
        public override bool Ispassed(int grade)
        {
            
            if (grade > 70)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    public class Grad:Student
    {
        public override bool Ispassed(int grade)
        {
            if (grade > 80)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
