using System;

namespace MotorChoices
{
    public class ACMotor: Motor
    {
        protected int phaseangle;
        public override int Voltage { get => voltage; set => voltage = value; }
        public override int Current { get => current; set => current = value; }
        public int PhaseAngle { get => phaseangle; set => phaseangle = value; }
        public override string Manufacturer { get => manufacturer; set => manufacturer = value; }
        public override int PiecePrice { get => pieceprice; set => pieceprice = value; }

        public override double CalculatePower() =>(Voltage / Math.Sqrt(2)) * (Current / Math.Sqrt(2)) * Math.Cos(PhaseAngle*(Math.PI/180));

        public override string Describe()
        {
            return string.Format(
                @"
                AC Motor
                Manufacturer: {0}
                Piece Price: {1}
                Power (Watts): {2}
                Voltage (V): {3}
                Current (A): {4}
                Phase Angle (deg): {5}",
            manufacturer, pieceprice, this.CalculatePower(), voltage, current, phaseangle);
        }
    }
}
