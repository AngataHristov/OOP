
namespace UniversityLearningSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using UniversityLearningSystem.Exceptions;
    using UniversityLearningSystem.Students;
    using UniversityLearningSystem.Trainers;
    using UniversityLearningSystem.Extencions;

    public class EntryPoint // SULSTest 
    {

        public static void Main()
        {
            List<Student> listOfPeople = new List<Student>()
            {
            new GraduatedStudent("Ivan","Asenov",30,"12948",5.3),

            new DropoutStudent("Petkan","Stonev",19,"15234",2.9,"Bad results"),

            new OnlineStudent("Desi","Angelova",25,"13245",4.5,"Programming basics"),

            new OnlineStudent("Angel","Georgiev",29,"14125",5.9,"Back-end")
            };

            // List<Student> sortedPeople = listOfPeople
            //     .Where(st => st is CurrentStudent)
            //     .OrderBy(st => st.AverageGrade)
            //     .ToList();
            // 
            // foreach (Student student in sortedPeople)
            // {
            //     Console.WriteLine(student);
            // }

            listOfPeople
                .Where(st => st is CurrentStudent)
                .OrderBy(st => st.AverageGrade)
                .ForEach(st => Console.WriteLine(st));
        }
    }
}