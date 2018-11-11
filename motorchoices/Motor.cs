using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace MotorChoices
{
    public abstract class Motor
    {
        protected double voltage;
        protected double current;
        protected string manufacturer;
        [JsonProperty(PropertyName = "Piece Price")]
        protected double pieceprice;
        protected string type;

        public abstract double Voltage { get; set; }
        public abstract double Current { get; set; }
        public abstract string Manufacturer { get; set; }
        public abstract double PiecePrice { get; set; }
        public abstract string Type { get; set; }

        public abstract double CalculatePower();
        public abstract string Describe();
    }
}
