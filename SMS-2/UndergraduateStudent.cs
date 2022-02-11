using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS_2
{
    internal class UndergraduateStudent : Student 
    {
        private string major;

        public UndergraduateStudent() { }

        public UndergraduateStudent(string id, string name, string major) : base(id, name)
        {
            // this.id = id;
            // this.name = name;
            this.major = major;
        }

        public string Major
        {
            get { return major; }
            set { major = value; }
        }

        public override void printStudent()
        {
            Console.WriteLine($"ID: {id}    Name: {name}    Major: {major}");
        }
    }
}
