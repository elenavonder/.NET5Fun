using System;

namespace FunWith.NET5
{
    class Program
    {
        static void Main(string[] args)
        {
            var cls1 = new Class("English", 101, null);
            Console.WriteLine($"{cls1.Id}, {cls1.Subject}");
        }
    }
}
