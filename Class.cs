using System;
namespace FunWith.NET5
{
    public class Class
    {
        private static int NextId = 1;

        public int Id { get; set; }
        public string Subject { get; set; }
        public int Section { get; set; }
        public int? InstructorId { get; set; }

        public void print()
        {
            Console.WriteLine($"Class: Id: {this.Id}, Subject: {this.Subject}," +
                $"Section: {this.Section}, InstructorId:{this.InstructorId}");
        }

        public Class(string subject, int section, int? instructorId)
        {
            this.Id = NextId++;
            this.Subject = subject;
            this.Section = section;
            this.InstructorId = instructorId;
        }
        public Class()
        {
        }
    }
}
