using System;
using System.Collections.Generic;
using System.Text;

namespace DDDAggregate {
    public class Car {
        public Wheel[] Wheels { get; set; }
        public Motor Motor { get; set; }

        public override string ToString() {
            StringBuilder builder = new StringBuilder("Motor.Block:");
            builder.Append(Motor.Block);
            builder.AppendLine();
            builder.Append("Wheels:");
            builder.AppendLine();
            foreach (Wheel item in Wheels) {
                builder.Append("Wheel.Tyre: ");
                builder.Append(item.Tyre);
                builder.Append(", Wheel.IsFlat: ");
                builder.Append(item.IsFlat);
                builder.AppendLine();
            }
            return builder.ToString();
        }
    }
}
