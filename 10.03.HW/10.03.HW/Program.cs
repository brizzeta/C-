using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace _10_03_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<Device> list = new List<Device>()
            //{
            //    new Device("IPhone X", "Apple", 499),
            //    new Device("IPhone 14 Pro", "Apple", 1000),
            //    new Device("Strix", "Asus", 1200)
            //};
            //List<Device> list2 = new List<Device>()
            //{
            //    new Device("Tuff Gaming", "Asus", 1000),
            //    new Device("IPhone 14 Pro", "Apple", 1000),
            //    new Device("PlayStation 5", "Sony", 499)
            //};

            //var result = list.Except(list2, new Sort());

            //foreach (var i in result)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine();
            //var result2 = list.Intersect(list2, new Sort());
            //foreach (var i in result2)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine();
            //var result3 = list.Union(list2, new Sort());

            //foreach (var i in result3)
            //{
            //    Console.WriteLine(i);
            //}

            FileStream stream = null;
            DataContractJsonSerializer jsonFormatter = null;
            XmlSerializer ser = null;
            Device obj = new Device();

            obj = new Device("IPhone X", "Apple", 499);
            stream = new FileStream("../../DeviceData.xml", FileMode.Create);
            ser = new XmlSerializer(typeof(Device));
            ser.Serialize(stream, obj);
            stream.Close();

            stream = new FileStream("../../DeviceData.xml", FileMode.Open);
            ser = new XmlSerializer(typeof(Device));
            obj = (Device)ser.Deserialize(stream);
            Console.WriteLine(obj.Name + " " + obj.Firm + " " + obj.Price);
            stream.Close();


            obj = new Device("Strix", "Asus", 1200);
            stream = new FileStream("../../Devicedata2.json", FileMode.Create);
            jsonFormatter = new DataContractJsonSerializer(typeof(Device));
            jsonFormatter.WriteObject(stream, obj);
            stream.Close();

            stream = new FileStream("../../Devicedata2.json", FileMode.Open);
            jsonFormatter = new DataContractJsonSerializer(typeof(Device));
            obj = (Device)jsonFormatter.ReadObject(stream);
            Console.WriteLine(obj.Name + " " + obj.Firm + " " + obj.Price);
            stream.Close();
        }

        public class Sort : IEqualityComparer<Device>
        {
            public bool Equals(Device x, Device y)
            {
                if (x.Name == y.Name)
                {
                    return true;
                }
                return false;
            }
            public int GetHashCode(Device obj)
            {
                return obj.Name.GetHashCode();
            }
        }
    }
}
