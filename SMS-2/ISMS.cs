using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS_2
{
    internal interface ISMS
    {
        void addStudent(Student s);
        void printStudentList();
        bool searchStudent(string s);
        void sortStudentList();
    }
}
