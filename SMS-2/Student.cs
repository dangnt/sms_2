using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS_2
{
    internal abstract class Student
    {
        protected string name;
        protected string id;

        public Student() { }

        public Student(string id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public string Name 
        { 
            get { return name; } 
            set { name = value; }
        }

        public string ID 
        {
            get { return id; } 
            set { id = value; }
        }

        public abstract void printStudent();
    }
}
