using System;
using Entities;
using System.Collections.Generic;
using System.Linq;
namespace ProgramingLogicTest {
    class Program {
        static void Main(string[] args) {
            List<Menu> list = new List<Menu>() {
                new Menu(){Id = 1, Name = "HotDog", Price = 4.00},
                new Menu(){Id = 2, Name = "X-Salada", Price = 4.50},
                new Menu(){Id = 3, Name = "X-Bancon", Price = 5.00},
                new Menu(){Id = 4, Name = "Torrada", Price = 2.00},
                new Menu(){Id = 5, Name = "CocaCola", Price = 1.50}                            
            };
            foreach(Menu obj in list) {
                Console.WriteLine("Id " + obj.Id + " | " + obj.Name + ", R$ " + obj.Price);
            }
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------");
            Console.Write("Digite o Id do produto: "); int orderId = int.Parse(Console.ReadLine());
            Console.Write("Digite a quantidade do produto: "); double amount = double.Parse(Console.ReadLine());          
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine();
            Order o = new Order(orderId, amount);
            Console.WriteLine(o);
        }
    }
}
