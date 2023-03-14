using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace _10_03_HW
{
    [Serializable]
    [DataContract]
    public sealed class Device
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Firm { get; set; }
        [DataMember]
        public double Price { get; set; }


        public Device()
        {
        }

        public Device(string name, string firm, double price)
        {
            Name = name;
            Firm = firm;
            Price = price;
        }

        public override string ToString() { return $"Device -> {Name}\nFirm -> {Firm}\nPrice -> {Price}"; }
    }
}
