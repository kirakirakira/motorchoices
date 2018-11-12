using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using System.Text;

namespace MotorChoices
{
    class Program
    {
        private static void Main()
        {
            // Get current file directory and create file name for data set: MotorData.json
            string currentDirectory = Directory.GetCurrentDirectory();
            DirectoryInfo directory = new DirectoryInfo(currentDirectory);
            var fileName = Path.Combine(directory.FullName, "ACMotorData.json");

            // Deserialize data in json file
            var acmotors = DeserializeMotors(fileName);

            // Display main menu
            DisplayMainMenu();

            // Get user input
            Console.WriteLine("Enter your selection: ");
            var userInput = Console.ReadLine();

            if (userInput == "1")
            {
                // Display current motors
                DisplayMotors(acmotors);
            }
            else if (userInput == "2")
            {
                // Ask user which motor to add
                Console.WriteLine("Please enter the motor id that you'd like to add to the database: ");
                var motorId = Console.ReadLine();
                AddToFavoriteList(FindMotorObjectById());
            }

            Console.ReadLine();
        }

        private static object FindMotorObjectById()
        {
            throw new NotImplementedException();
        }

        private static void AddToFavoriteList(object findMotorObjectById)
        {
            throw new NotImplementedException();
        }

        public static List<ACMotor> DeserializeMotors(string fileName)
        {
            var acmotors = new List<ACMotor>();
            var serializer = new JsonSerializer();
            using (var reader = new StreamReader(fileName))
            using (var jsonReader = new JsonTextReader(reader))
            {
                acmotors = serializer.Deserialize<List<ACMotor>>(jsonReader);
            }
            return acmotors;
        }

        public static void DisplayMotors(List<ACMotor> acmotors)
        {
            Console.WriteLine("These are the current motors in our database: ");

            int overallIndex = 0;
            int pageIncrement = 3;
            while (overallIndex < acmotors.Count)
            {
                for (int i = overallIndex; i < overallIndex+pageIncrement; i++)
                {
                    if (i < acmotors.Count)
                    {
                        Console.WriteLine(acmotors[i].Describe());
                    }

                }
                Console.WriteLine("Press enter to display more.");
                Console.ReadLine();
                overallIndex += pageIncrement;
            }
        }

        public static void DisplayMainMenu()
        {
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("--------MOTOR DB & POWER CALCULATOR -------");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Options are:");
            Console.WriteLine("1: Display all motors");
            Console.WriteLine("2: Display favorites list");
        }

        public static void DisplayMotorMenu()
        {
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("--------MOTOR SELECTION & CALCULATOR ------");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Options are:");
            Console.WriteLine("1: Calculate power");
            Console.WriteLine("2: Add motor to favorite list by id #");
            Console.WriteLine("3: Remove motor from favorite list by id#");
        }
    }
}
