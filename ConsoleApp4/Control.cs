using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Control
    {
        public static void Main(string[] args)
        {
            var quit = false;
            var tasks = new List<string>();
            var route = @"C:\Users\white\Desktop\TASKS.txt";

            
            try
            {NoDb.
                StreamReader sw = new StreamReader(route, true, Encoding.ASCII);
                {
                    for (int i = 0; i < tasks.Count; ++i)
                    {
                        sw.ReadLine($"{i + 1}. {tasks[i]}");
                    }
                }
                sw.Close();
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
            do
            {
                PrintMenu();
                Console.Write("Select your item:");
                var input = Console.ReadLine();

                quit = HandleInput(tasks, input);
            } while (!quit);

            try
            {
               
                StreamWriter sw = new StreamWriter(route, true, Encoding.ASCII);
                
                for (int i = 0; i < tasks.Count; ++i)
                {
                    sw.WriteLine($"{i + 1}. {tasks[i]}");
                }
                
                sw.Close();
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }


        private static bool HandleInput(List<string> tasks, string input)
        {
            var quit = false;

            if (input == "0")
            {
                quit = true;
            }
            else if (input == "1")
            {
                // Now, we have a place to store the tasks called ("tasks")
                // Lets provide a prompt:
                Console.Write("Enter your task: ");
                var newTask = Console.ReadLine();

                // Now, add the input task to the list.
                tasks.Add(newTask);
            }
            else if (input == "2")
            {
                Console.Clear();
                for (int i = 0; i < tasks.Count; ++i)
                {
                    Console.WriteLine($"{i + 1}. {tasks[i]}");
                }

                Console.Write("Press any key to return to main menu...");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Invalid input...Press any key to return to main menu...\n");
                Console.ReadKey();
            }

            return quit;

        }

        private static void PrintMenu()
        {
            Console.Clear();
            Console.WriteLine("Task List");
            Console.WriteLine("----------");
            Console.WriteLine(" 1. Add a Task");
            Console.WriteLine(" 2. Display Task List");
            Console.WriteLine(" 0. Quit");
        }
    }
}

 