using System;

namespace MotorChoices
{
    class Program
    {
        public static void Main(string[] args)
        {
            DCMotor mtr1 = new DCMotor();
            mtr1.Current = 5;
            mtr1.Voltage = 12;
            mtr1.Manufacturer = "ABC Inc.";
            mtr1.PiecePrice = 1;

            Console.WriteLine(mtr1.Describe());

            ACMotor mtr2 = new ACMotor();
            mtr2.Current = 5;
            mtr2.Voltage = 12;
            mtr2.PhaseAngle = 60;
            mtr2.Manufacturer = "ABC Inc.";
            mtr2.PiecePrice = 1;

            Console.WriteLine(mtr2.Describe());

            Console.ReadLine();
        }
    }
}
