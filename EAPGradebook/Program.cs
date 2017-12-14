using System;
using Students.Core.Classes;

namespace EAPGradebook
{
    class Program
    {
        static void Main(string[] args)
        {
            MessageLine("Erick's GradeBook\n");

            StudentList myList = new StudentList();
            ScoresAverages allGrades = new ScoresAverages();

            AddStudents(myList);
            GradebookLoop(myList, allGrades);
        }

        private static void GradebookLoop(StudentList myList, ScoresAverages allGrades)
        {
            while (true)
            {
                MessageLine("\nWhat would you like to do? \n\n" +
                    "Add grades to students. Type 1 \n" +
                    "Print all grades. Type 2 \n" +
                    "Print grade average. Type 3 \n" +
                    "Quit? Type 0\n");

                int response = int.Parse(Console.ReadLine());

                if (response == 1)
                {
                    foreach (var item in myList)
                    {
                        Console.Write($"{item.Name}: ");
                        int newGrade = int.Parse(Console.ReadLine());

                        item.Score = newGrade;
                    }
                }
                else if (response == 2)
                {
                    foreach (var item in myList)
                    {
                        Console.WriteLine(value: $"{item.Name}: {item.Score}%");
                    }
                }
                else if (response == 3)
                {
                    allGrades.CalculateAverage(myList);

                    Console.WriteLine(value: $"Average grade: {allGrades.Average}%");
                }
                else
                {
                    break;
                }
            }
        }

        private static void AddStudents(StudentList myList)
        {
            MessageLine("Press Return when done\n");

            while (true)
            {
                Message("Student Name: ");

                string name = Console.ReadLine();

                if (name == "")
                {
                    break;
                }
                else
                {
                    myList.AddStudent(name);
                    continue;
                }
            }
        }

        private static void Message(string message)
        {
            Console.Write(message);
        }

        private static void MessageLine(string message)
        {
            Console.WriteLine(message);
        }
    }
}
