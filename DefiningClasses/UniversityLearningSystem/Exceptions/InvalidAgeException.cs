
namespace UniversityLearningSystem.Exceptions
{
    using System;

    public class InvalidAgeException : ApplicationException
    {
        public InvalidAgeException(string message, int minAge, int maxAge)
            : base(message)
        {
            this.MinAge = minAge;
            this.MaxAge = MaxAge;
        }

        public int MinAge { get; private set; }

        public int MaxAge { get; private set; }
    }
}
