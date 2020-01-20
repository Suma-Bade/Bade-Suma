using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAss
{
    class Trainee1
    {
        public static void Main(string[] args)
        {
            List<Trainee> lst = new List<Trainee>();
            Console.WriteLine("enter no of trainees");
            int n = int.Parse(Console.ReadLine());
            for(int i=0;i<n;i++)
            {
                Console.WriteLine("enter id");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("enter name");
                string name = Console.ReadLine();
                Console.WriteLine("enter project id");
                int projectId = int.Parse(Console.ReadLine());
                lst.Add(new Trainee(id, name, projectId));
            }
            List<Trainee> pi = lst.FindAll(y => y.ProjectId != -1);
            foreach(Trainee s in pi)
            {
                Console.WriteLine(s);
            }
            Console.ReadLine();

        }
    }
}
