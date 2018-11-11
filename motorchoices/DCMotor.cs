using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace MotorChoices
{
    public class DCMotor: Motor
    {
        [JsonProperty(PropertyName = "Voltage")]
        public override double Voltage { get => voltage; set => voltage = value; }
        public override double Current { get => current; set => current = value; }
        [JsonProperty(PropertyName = "Manufacturer")]
        public override string Manufacturer { get => manufacturer; set => manufacturer = value; }
        [JsonProperty(PropertyName = "Piece Price")]
        public override double PiecePrice { get => pieceprice; set => pieceprice = value; }
        public override string Type { get => type; set => type = value; }

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
