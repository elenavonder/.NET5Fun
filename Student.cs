using System;
namespace FunWith.NET5
{
    public class Student
    {

        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int SAT { get; set; }
        public double GPA { get; set; }
        public int? MajorId { get; set; }
        public Major Major { get; set; }

        public string Fullname()
        {
            var fullname = $"{this.Lastname}, {this.Firstname}";
            return fullname;
        }
        public Student()
        {
        }
    }
}
