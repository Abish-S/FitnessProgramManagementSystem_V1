using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessProgramManagementSystem
{
    internal class FitnessProgram
    {
        public string FitnessProgramId { get; set; }
        public string Title { get; set; }
        public string Duration { get; set; }
        public string Price { get; set; }

        public FitnessProgram(string fitnessProgramId, string title, string duration, string price)
        {
            FitnessProgramId = fitnessProgramId;
            Title = title;
            Duration = duration;
            Price = price;
        }

        public override string ToString()
        {
            return $"fitnessProgramId: {FitnessProgramId}, Title: {Title}, Duration: {Duration}, Price: {Price}";
        }
    }
}
