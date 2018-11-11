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
            var fileName = Path.Combine(directory.FullName, "MotorData.json");

            // Deserialize data in json file
            var motors = DeserializeMotors(fileName);

            Console.ReadLine();
        }

        public static List<Motor> DeserializeMotors(string fileName)
        {
            var motors = new List<Motor>();
            var serializer = new JsonSerializer();
            using (var reader = new StreamReader(fileName))
            using (var jsonReader = new JsonTextReader(reader))
            {
                motors = serializer.Deserialize<List<Motor>>(jsonReader);
            }
            return motors;
        }
    }
}
