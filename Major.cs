using System;
namespace FunWith.NET5
{
    public class Major
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int MinSAT { get; set; }
        // Methodss

        public void SetMinSAT(int minsat)
        {
            if (minsat < 400 || minsat > 1600)
            {
                Console.WriteLine($"ERROR minsat outside bounds");
                return;
            }
            this.MinSAT = minsat;
        }

        public Major (int id, string desc, int MinSAT)
        {
            this.Id = id;
            this.Description = desc;
            this.MinSAT = MinSAT = 400;
            this.SetMinSAT(MinSAT);
        }
        
        public Major()
        {
        }
    }
}
