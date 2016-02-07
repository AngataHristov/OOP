
namespace GenericList
{
    using System;


    [AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
    public class VersionAttribute : Attribute
    {
        public VersionAttribute(string major, string minor)
        {
            this.Major = major;
            this.Minor = minor;
        }

        public string Major { get; set; }

        public string Minor { get; set; }

        public override string ToString()
        {
            return string.Format("{0}.{1}", this.Major, this.Minor); 
        }
    }
}
