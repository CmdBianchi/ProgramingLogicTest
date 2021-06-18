using System;
using System.Collections.Generic;
using System.Linq;
namespace ProgramingLogicTest {
    class Program {
        static void Main(string[] args) {
            Console.Write("How many values? ");
            int quantiy = int.Parse(Console.ReadLine());
            List<int> list = new List<int>(); //-----------------> Declaração da lista

            for (int i = 1; i <= quantiy; i++) {         //-----------------> Quantidade de Valores a ser adicionados. 
                Console.WriteLine("Number #" + i + ":");
                int x = int.Parse(Console.ReadLine());
                list.Add(x);
            }

            Console.WriteLine();
            Console.WriteLine("---------------");
            foreach (int obj in list) {   //-----------------> Printa valores da lista    
                Console.WriteLine(obj);
            }

            int[] outPut = list.ToArray();
            

        }                  
    }
}
