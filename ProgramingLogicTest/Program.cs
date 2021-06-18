using System;
using Entities;
using System.Collections.Generic;
using System.Linq;
namespace ProgramingLogicTest {
    class Program {
        static void Main(string[] args) {
            Console.Write("Entre com VALOR A: "); double a = double.Parse(Console.ReadLine());
            Console.Write("Entre com VALOR B: "); double b = double.Parse(Console.ReadLine());
            Console.Write("Entre com VALOR C: "); double c = double.Parse(Console.ReadLine());

            Calculator calculator = new Calculator(a, b, c);
            if(calculator.Verif() == true) {
                Console.WriteLine("--------------------------------");
                Console.WriteLine(calculator);
            }
            else {
                Console.WriteLine("-------------------------------");
                Console.WriteLine("Impossivel calcular");
            }
        }
    }
}
