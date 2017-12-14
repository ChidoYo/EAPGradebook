using System.Collections;
using System.Collections.Generic;

namespace Students.Core.Classes
{
    public class StudentList : IEnumerable<StudentRecord>
    {
        public StudentList()
        {
            studentList = new List<StudentRecord>();
        }

        private List<StudentRecord> studentList;

        public IEnumerator<StudentRecord> GetEnumerator()
        {
            return studentList.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return studentList.GetEnumerator();
        }

        public void AddStudent(string student)
        {
            studentList.Add(new StudentRecord()
            {
                Name = student
            });
        }

        public int Count {  get { return studentList.Count; } }
    }

    public class StudentRecord
    {
        public decimal Score { get; set; }
        public string Name { get; set; }
    }
}
