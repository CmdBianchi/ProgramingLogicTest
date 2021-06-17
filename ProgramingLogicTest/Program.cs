using System;
using Entities;
namespace ProgramingLogicTest {
    class Program {
        static void Main(string[] args) {
            Console.Write("Entre com o VALOR DO RAIO: ");     
            double radius = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Calculator c = new Calculator(radius);                     
            Console.WriteLine(c);
        }
    }
}
