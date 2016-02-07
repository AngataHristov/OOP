
namespace CustomLINQ
{
    using System;
    using System.Collections.Generic;

    public class EntryPoint
    {
        public static void Main()
        {
            List<int> nums = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var filteredCollection = nums.WhereNot(x => x % 2 == 0);

            Console.WriteLine(string.Join(", ", filteredCollection));

            var students = new List<Student>
            {
                new Student("Pesho",23),
                new Student("Geri",18),
                new Student("Petq",50),
                new Student("Kiro",40)
            };

            var result = students.Max(st => st.Age);

            Console.WriteLine(result);
        }
    }
}
