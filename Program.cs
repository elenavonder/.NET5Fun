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

            var Accounting = new Major();
            Accounting.Id = 2;
            Accounting.Description = "Accounting for Beginners";
            Accounting.SetMinSAT(1300);

            var BasketWeaving = new Major(3, "Basket Weaving", 600);

            Console.WriteLine($"minsat is {BasketWeaving.MinSAT}");

            var std1 = new Student();
            std1.Id = 1;
            std1.Firstname = "Zachary";
            std1.Lastname = "Smith";
            std1.GPA = 3.0;
            std1.SAT = 1300;
            std1.MajorId = BasketWeaving.Id;
            std1.Major = BasketWeaving;

            var std2 = new Student();
            std2.Id = 2;
            std2.Firstname = "Megan";
            std2.Lastname = "Louise";
            std2.GPA = 3.5;
            std2.SAT = 1200;
            std2.MajorId = Business.Id;
            std2.Major = Business;

            Console.WriteLine($"Name is " +
                $"{std1.Fullname()} majors in {std1.Major.Description}");

            var Psychology = new Major();
            Psychology.Id = 4;
            Psychology.Description = "Psychology 101";
            Psychology.SetMinSAT(1200);

            var std3 = new Student();
            std3.Id = 3;
            std3.Firstname = "Jo";
            std3.Lastname = "Gallagher";
           
        }
    }
}
