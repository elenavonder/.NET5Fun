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

        }
        public Class()
        {
        }
    }
}
