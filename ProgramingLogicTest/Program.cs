using System;
using Entities;
using System.Collections.Generic;
using System.Linq;
namespace ProgramingLogicTest {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Digite senha: ");
            int pw = int.Parse(Console.ReadLine());
            VerifyPassWord vpw = new VerifyPassWord(pw);

            while (vpw.Verify() != true) {
                Console.WriteLine("INVALID PASSWORD !!!");
                pw = int.Parse(Console.ReadLine());
                vpw = new VerifyPassWord(pw);
            }

            Console.WriteLine("PASS GRANTED");
        }
    }
}
