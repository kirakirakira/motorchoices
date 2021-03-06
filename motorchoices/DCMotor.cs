﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace MotorChoices
{
    public class DCMotor: Motor
    {
        [JsonProperty(PropertyName = "ID")]
        public override int ID { get => id; set => id = value; }
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
                #{0} - DC Motor
                Manufacturer: {1}
                Piece Price: {2}
                Power (Watts): {3}
                Voltage (V): {4}
                Current (A): {5}",
            id, manufacturer, pieceprice, this.CalculatePower(), voltage, current);
        }
    }
}
