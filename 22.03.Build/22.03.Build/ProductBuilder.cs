using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22._03.Build
{
    internal interface IProductBuilder
    {
        void BuildFrame();
        void BuildEngine();
        void BuildWheel();
        void BuildTransmission();
        Product GetProduct();
    }
    internal class DaewooLanos : IProductBuilder
    {
        Product product;
        public DaewooLanos()
        {
            product = new Product();
        }
        public void BuildFrame()
        {
            product.Frame = "Sedan";
        }
        public void BuildEngine()
        {
            product.Engine = 98;
        }
        public void BuildWheel()
        {
            product.Wheel = 13;
        }
        public void BuildTransmission()
        {
            product.Transmission = "5 Manual";
        }
        public Product GetProduct()
        {
            return product;
        }
        public override string ToString()
        {
            return $"Frame — {product.Frame}\nEngine - {product.Engine}\nWheel - {product.Wheel}\nTransmission - {product.Transmission}";
        }
    }
    internal class Ford_Probe : IProductBuilder
    {
        Product product;
        public Ford_Probe()
        {
            product = new Product();
        }
        public void BuildFrame()
        {
            product.Frame = "Coupe";
        }
        public void BuildEngine()
        {
            product.Engine = 160;
        }
        public void BuildWheel()
        {
            product.Wheel = 14;
        }
        public void BuildTransmission()
        {
            product.Transmission = "4 Auto";
        }
        public Product GetProduct()
        {
            return product;
        }
        public override string ToString()
        {
            return $"Frame — {product.Frame}\nEngine - {product.Engine}\nWheel - {product.Wheel}\nTransmission - {product.Transmission}";
        }
    }
    internal class UAZ_Patriot : IProductBuilder
    {
        Product product;
        public UAZ_Patriot()
        {
            product = new Product();
        }
        public void BuildFrame()
        {
            product.Frame = "Station wagon";
        }
        public void BuildEngine()
        {
            product.Engine = 120;
        }
        public void BuildWheel()
        {
            product.Wheel = 16;
        }
        public void BuildTransmission()
        {
            product.Transmission = "4 Manual";
        }
        public Product GetProduct()
        {
            return product;
        }
        public override string ToString()
        {
            return $"Frame — {product.Frame}\nEngine - {product.Engine}\nWheel - {product.Wheel}\nTransmission - {product.Transmission}";
        }
    }
}
