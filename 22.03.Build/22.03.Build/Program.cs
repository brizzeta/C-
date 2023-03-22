using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22._03.Build
{
    internal class Shop
    {
        IProductBuilder product_builder;
        public Shop(IProductBuilder product_builder)
        {
            this.product_builder = product_builder;
        }
        public static Product ConstructProduct(IProductBuilder product_builder)
        {
            product_builder.BuildFrame();
            product_builder.BuildEngine();
            product_builder.BuildWheel();
            product_builder.BuildTransmission();

            return product_builder.GetProduct();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Shop.ConstructProduct(new DaewooLanos()));
        }
    }
}
