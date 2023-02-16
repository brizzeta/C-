using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._02._2023.Inheritance {
    internal class Money {
        internal int Bills { get; set; }
        internal int Coins { get; set; }
        public Money():this(0,0) { }
        public Money(int bills, int coins) {
            Bills = bills;
            Coins = coins;
        }
        internal virtual void Print() => Console.WriteLine($"Balance: {Bills}.{Coins}");
    }
    internal class Product : Money {
        internal int PriceBills { get; set; }
        internal int PriceCoins { get; set; }
        internal Product() :this(0, 0) { }
        internal Product(int Pbills, int Pcoins) {
            PriceBills = Pbills;
            PriceCoins = Pcoins;
        }
        internal override void Print() {
            base.Print();
            Console.WriteLine($"Price: {PriceBills}.{PriceCoins}");
        }
        internal void ChangePrice(int bills, int coins) {
            PriceBills = bills;
            PriceCoins = coins;
        }
    }
}
