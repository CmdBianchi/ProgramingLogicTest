using System;
using System.Collections.Generic;
using System.Text;
namespace Entities {
    class Calculator {
        public double PieceX { get; set; }
        public int QuantityX { get; set; }
        public double PieceY { get; set; }
        public int QuantityY { get; set; }
        public Calculator(double pieceX, int quantityX, double pieceY, int quantityY) {
            PieceX = pieceX;
            QuantityX = quantityX;
            PieceY = pieceY;
            QuantityY = quantityY;
        }
        public double TotalAccount() {
            return PieceX * QuantityX + PieceY * QuantityY;
        }
        public override string ToString() {
            return "VALOR A PAGAR: R$" + TotalAccount().ToString("F2");
        }
    }
}
