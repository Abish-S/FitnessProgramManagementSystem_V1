using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessProgramManagementSystem
{
    internal class fitnessProgramManager
    {
        private List<FitnessProgram> fitnessPrograms = new List<FitnessProgram>();

        public void CreateFitnessProgram(FitnessProgram fitnessProgram)
        {
            fitnessPrograms.Add(fitnessProgram);
        }

        public List<FitnessProgram> ReadFitnessPrograms()
        {
            return fitnessPrograms;
        }

        public void UpdateFitnessProgram(string newFitnessProgramId, string newTitle, string newDuration, string newPrice)
        {
            var program = fitnessPrograms.FirstOrDefault(p => p.FitnessProgramId == newFitnessProgramId);
            if (program != null)
            {
                program.Title = newTitle;
                program.Duration = newDuration;
                program.Price = newPrice;


            }

        }

        public void DeleteFitnessProgram(string id)
        {
            var program = fitnessPrograms.FirstOrDefault(p => p.FitnessProgramId == id);
            if (program != null)
            {
                fitnessPrograms.Remove(program);
            }

        }
    }
}
