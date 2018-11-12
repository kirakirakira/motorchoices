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

            // Display current motors
            DisplayMotors(acmotors);

            Console.ReadLine();
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
    }
}
