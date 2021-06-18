using System;
using System.Collections.Generic;
using System.Text;
namespace Entities {
    class Order {
        public int OrderId { get; set; }
        public double Amount { get; set; }
        public Order(int orderId, double amount) {
            OrderId = orderId;
            Amount = amount;
        }
        public double Total() {
            if (OrderId == 1) {                
                return Amount * 4.0;               
            }
            else if (OrderId == 2 ){
                return Amount * 4.5;
            }
            else if (OrderId == 3) {
                return Amount * 5.0;  
            }
            else if (OrderId == 4) {
                return Amount * 2.0;               
            }
            else {
                return Amount * 1.5;           
            }            
        }
        public override string ToString() {
            return "Valor total a pagar: $" + Total();
        }
    }
}
