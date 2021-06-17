using System;
using Entities;
namespace ProgramingLogicTest {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Entre com o VALOR do PRODUTO 1 e QUANTIDADE: ");
            double priceX = double.Parse(Console.ReadLine());
            int quantityX = int.Parse(Console.ReadLine());
            Console.WriteLine("\nEntre com o VALOR do PRODUTO 2 e QUANTIDADE: ");
            double priceY = double.Parse(Console.ReadLine());
            int quantityY = int.Parse(Console.ReadLine());
            Calculator c = new Calculator(priceX, quantityX, priceY, quantityY);
            Console.WriteLine(c);
        }
    }
}
