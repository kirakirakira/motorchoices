using System;

namespace MotorChoices
{
    public class DCMotor: Motor
    {
        public override int Voltage { get => voltage; set => voltage = value; }
        public override int Current { get => current; set => current = value; }
        public override string Manufacturer { get => manufacturer; set => manufacturer = value; }
        public override int PiecePrice { get => pieceprice; set => pieceprice = value; }

        public override double CalculatePower()
        {
            return Voltage * Current;
        }

        public override string Describe()
        {
            return string.Format(
                @"
                DC Motor
                Manufacturer: {0}
                Piece Price: {1}
                Power (Watts): {2}
                Voltage (V): {3}
                Current (A): {4}",
            manufacturer, pieceprice, this.CalculatePower(), voltage, current);
        }
    }
}
