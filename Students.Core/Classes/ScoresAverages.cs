using System;
using System.Collections.Generic;
using System.Text;

namespace Students.Core.Classes
{
    public class ScoresAverages
    {
        private List<StudentRecord> allGrades;

        public ScoresAverages()
        {
            allGrades = new List<StudentRecord>();
        }

        decimal totalAdded;
        decimal finalAverage;

        public void CalculateAverage(List<StudentRecord> myList)
        {
            foreach (var item in myList)
            {
                totalAdded += item.Score;
            }

            finalAverage = totalAdded / myList.Count;
        }

        public decimal Average { get { return finalAverage; } }
    }
}
