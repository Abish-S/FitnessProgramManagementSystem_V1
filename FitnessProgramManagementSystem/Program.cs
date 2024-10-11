using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessProgramManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FitnessProgramManager manager = new FitnessProgramManager();
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("Fitness Program Management System");
                Console.WriteLine("1.Add a FitnessProgram");
                Console.WriteLine("2.View All FitnessPrograms");
                Console.WriteLine("3.Update a FitnessProgram");
                Console.WriteLine("4.Delete a FitnessProgram");
                Console.WriteLine("5.Exit");

                switch (Console.ReadLine())
                {
                    case "1":
                        {
                            AddProgram(manager);

                        }
                        break;
                    case "2":
                        {
                            ReadAllProgram();
                        }
                        break;
                    case "3":
                        {
                            Updateprogram();
                        }
                        break;
                    case "4":
                        {
                            DeleteProgram();
                        }
                        break;
                    case "5":
                        {
                            exit = true;
                        }
                        break;
                    default:
                        {
                            Console.WriteLine("invalid option");
                        }
                        break;


                }

                void AddProgram(FitnessProgram program)
                {
                    Console.WriteLine("Enter FitnessProgram ID");
                    string id = Console.ReadLine();

                    Console.WriteLine("Enter FitnessProgram Title");
                    string title = Console.ReadLine();

                    Console.WriteLine("Enter Fitness Program Duration");
                    string duration = Console.ReadLine();

                    Console.WriteLine("Enter Fitness Program Price");
                    string price = Console.ReadLine();

                    FitnessProgram fitnessProgram = new FitnessProgram(id, title, duration, price);

                    manager.CreateFitnessProgram(fitnessProgram);

                }

                void ReadAllProgram(FitnessProgram program)
                {
                    var programs = manager.ReadFitnessPrograms();
                    if (programs.Count == 0)
                    {
                        Console.WriteLine("no programs found");
                    }



                }

                void Updateprogram(FitnessProgram program)
                {

                    Console.WriteLine("Enter new FitnessProgram ID");
                    string id = Console.ReadLine();

                    Console.WriteLine("Enter new FitnessProgram Title");
                    string title = Console.ReadLine();

                    Console.WriteLine("Enter new Fitness Program Duration");
                    string duration = Console.ReadLine();

                    Console.WriteLine("Enter new Fitness Program Price");
                    string price = Console.ReadLine();

                    manager.UpdateFitnessProgram(program);


                }

                void DeleteProgram(FitnessProgram program);
                {
                    Console.WriteLine("Enter ID to Delete");
                    string id = Console.ReadLine();

                    manager.DeleteFitnessProgram(id);
                }
            }
        
        }
    }
}
