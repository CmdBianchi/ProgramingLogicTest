using System;
using System.Collections.Generic;
using System.Text;
namespace Entities {
    class Calculator {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }
        public Calculator(double a, double b, double c) {
            A = a;
            B = b;
            C = c;
        }   
        public double Delta() {           
            return (B * B) - (4 * A * C);          
        } 
        public bool Verif() {
            if(Delta() >= 0 && A != 0) {
                return true;
            }
            else {
                return false;
            }
        }
        public double BhaskaraSqrtPos() {            
            return(-B + Math.Sqrt(Delta()))/(2*A);                                              
        }
        public double BhaskaraSqrtNeg() {
            return (-B - Math.Sqrt(Delta()))/(2*A);
        }
        public override string ToString() {
            return "X1 = " + BhaskaraSqrtPos().ToString("F4")+
                   "\nX2= " + BhaskaraSqrtNeg().ToString("F4");
        }

    }
}
