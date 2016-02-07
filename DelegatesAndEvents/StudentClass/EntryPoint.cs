
namespace StudentClass
{
    using System;

    public class EntryPoint
    {
        public static void Main()
        {
            Student student = new Student("Pesho", 23);

            student.OnPropertyChanged += (sender, eventArgs) =>
            {
                Console.WriteLine("Property changed: {0} (from {1} to {2})",
                    eventArgs.PropertyName, eventArgs.OldValue, eventArgs.NewValue);
            };
            student.Name = "Maria";
            student.Age = 19;
        }
    }
}
