
namespace HumanStudentWorker
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class EntryPoint
    {
        public static void Main()
        {
            Console.WriteLine("Students:");

            List<Student> students = new List<Student>
                {
                    new Student("Ivan", "Ivanov", 126512),
                    new Student("Georgi", "Ivanov", 623612),
                    new Student("Georgi", "Georgiev", 212412),
                    new Student("Aleksandar", "Garov", 9001242),
                    new Student("Petur", "Petorv", 184512),
                    new Student("Goshko", "Goshkov", 100512),
                    new Student("Pesho", "Peshev", 12600212),
                    new Student("Teodor", "Ivanov", 12634512),
                    new Student("Stamat", "Ivanov", 12651512),
                    new Student("Mariika", "Ivanova", 126002)
                };

            students = students.OrderBy(st => st.FacultyNumber).ToList();

            foreach (var studen in students)
            {
                Console.WriteLine(studen);
            }

            Console.WriteLine("Workers:");

            List<Worker> workers = new List<Worker>
                {
                    new Worker("Ivan", "Ivanov", 8, 512m),
                    new Worker("Georgi", "Ivanov", 10, 999m),
                    new Worker("Georgi", "Georgiev", 4, 330m),
                    new Worker("Aleksandar", "Garov", 11, 1100m),
                    new Worker("Petur", "Petorv", 6, 650m),
                    new Worker("Goshko", "Goshkov", 8, 660m),
                    new Worker("Pesho", "Peshev", 4, 660m),
                    new Worker("Teodor", "Ivanov", 3, 142m),
                    new Worker("Stamat", "Ivanov", 10, 2200m),
                    new Worker("Mariika", "Ivanova", 7, 860m)
                };

            workers = workers.OrderByDescending(w => w.MoneyPerHour()).ToList();

            foreach (var worker in workers)
            {
                Console.WriteLine(worker);
            }

            Console.WriteLine();

            List<Human> humans = new List<Human>();

            humans.AddRange(students);

            humans.AddRange(workers);

            humans = humans
                .OrderBy(h => h.FristName)
                .ThenBy(h => h.LastName)
                .ToList();

            foreach (var human in humans)
            {
                Console.WriteLine(human);
            }
        }
    }
}
