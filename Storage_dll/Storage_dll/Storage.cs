using System.Xml.Serialization;

namespace Storage_dll
{
    [XmlInclude(typeof(HDD))]
    [XmlInclude(typeof(Flash))]
    [XmlInclude(typeof(DVD))]
    [Serializable]
    public class Storage
    {
        public string Manufacturer { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public int Capacity { get; set; }
        public int Count { get; set; }
        public Storage() 
        {
            Manufacturer = string.Empty;
            Name = string.Empty;
            Model = string.Empty;
            Capacity = 0;
            Count = 0;
        }
        public Storage(string Manufacturer, string Name, string Model, int Capacity, int Count) { 
            this.Manufacturer = Manufacturer;
            this.Name = Name;
            this.Model = Model;
            this.Capacity = Capacity;
            this.Count = Count;
        }
        public virtual void Print()
        {
            Console.WriteLine("Manufacturer: " + Manufacturer);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Model: " + Model);
            Console.WriteLine("Capacity: " + Capacity);
            Console.WriteLine("Count: " + Count);
        }
    }
}