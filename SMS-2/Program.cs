using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentList uStudentList = new StudentList();

            uStudentList.addStudent(new UndergraduateStudent("2021001", "Tran Nguyen", "CS"));
            uStudentList.addStudent(new UndergraduateStudent("2021002", "Pham Le", "CS"));

            uStudentList.sortStudentList();

            uStudentList.printStudentList();

            if (uStudentList.searchStudent("Tran Nguyen"))
            {
                Console.WriteLine("This student is found in the list!");
            }

            Console.ReadKey();
        }
    }
}
