using System;
using System.Collections.Generic;
using System.Text;

namespace Grades.Core.Classes
{
    public class Students
    {
        public StudentList()
        {
            students = new List<string>();
        }

        public void AddStudent(string student)
        {
            students.Add(student);
        }

        protected List<string> students;
    }
}
