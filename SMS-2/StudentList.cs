using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS_2
{
    internal class StudentList : ISMS
    {
        private ArrayList studentList;

        public StudentList() 
        {
            studentList = new ArrayList();
        }

        public class myComparer : IComparer
        {
            int IComparer.Compare(Object xx, Object yy)
            {
                UndergraduateStudent x = (UndergraduateStudent)xx;
                UndergraduateStudent y = (UndergraduateStudent)yy;

                //sort by name
                return x.Name.CompareTo(y.Name);
            }
        }

        public void addStudent(Student s)
        {
            studentList.Add(s);
        }

        public void printStudentList()
        {
            foreach (Student s in studentList)
            {
                s.printStudent();
            }
        }

        public bool searchStudent(string name)
        {
            foreach (Student s in studentList)
            {
                if (s.Name == name) return true;
            }

            return false;
        }

        public void sortStudentList()
        {
            studentList.Sort(new myComparer());
        }
    }
}
