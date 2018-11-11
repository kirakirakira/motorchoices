using System;

namespace MotorChoices
{
    public abstract class Motor
    {
        protected int voltage;
        protected int current;
        protected string manufacturer;
        protected int pieceprice;

        public abstract int Voltage { get; set; }
        public abstract int Current { get; set; }
        public abstract string Manufacturer { get; set; }
        public abstract int PiecePrice { get; set; }

        public abstract double CalculatePower();
        public abstract string Describe();
    }
}
