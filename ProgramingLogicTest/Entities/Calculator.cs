using System;
using System.Collections.Generic;
using System.Text;
namespace Entities {
    class Calculator {
        public double Radius { get; set; }

        public Calculator(double radius) {
            Radius = radius;
        }
        public double Area() {
            return 3.14159 * Radius * Radius;
        }
        public override string ToString() {
            return "O valor da AREA: " + Area().ToString("F2");
        }
    }
}
