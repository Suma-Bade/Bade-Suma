using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAss
{
    class Trainee
    {
        int id;
        string name;
        int projectId;
        public Trainee(int id,string name,int projectId)
        {
            this.Id = id;
            this.Name = name;
            this.ProjectId = projectId;

        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int ProjectId { get => projectId; set => projectId = value; }
        public override string ToString()
        {
            return "Id is "+this.id + "\nName is " + this.name + "\nProject id " + this.projectId;
        }
    }
}
