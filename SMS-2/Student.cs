using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS_1
{
    interface IStudent
    {
        void printStudent();
    }

    internal class Student : IStudent
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

        public void printStudent()
        {
            Console.WriteLine($"ID: {id}    Name: {name}");
        }
    }
}
