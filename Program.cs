using System;

namespace FunWith.NET5
{
    class Program
    {
        static void Main(string[] args)
        {
            var cls1 = new Class("English", 101, null);
            Console.WriteLine($"{cls1.Id}, {cls1.Subject}");

            var cls2 = new Class("Basket Weaving", 901, null);
            Console.WriteLine($"{cls2.Id}, {cls2.Subject}");

            var Business = new Major();
            Business.Id = 1;
            Business.Description = "General Busniess";
            Business.SetMinSAT(900);

            

        }
    }
}
