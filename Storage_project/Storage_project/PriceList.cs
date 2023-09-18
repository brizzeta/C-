using Storage_dll;
using Serialize;

namespace Storage_
{
    [Serializable]
    internal class PriceList
    {
        List<Storage> list;

        public PriceList()
        {
            list = new List<Storage>();
        }

        public void Add(Storage storage)
        {
            list.Add(storage);
        }

        public void Remove(string Model)
        {
            Storage? obj = list.Find(e => e.Model == Model);
            if (obj != null)
            {
                list.Remove(obj);
            }
            else
            {
                Console.WriteLine("Enter correct model.");
            }
        }

        public void Edit(string Manufacturer, string Name, string Model, int Capacity, int Count, double Add_Info)
        {
            Storage? obj = list.Find(e => e.Model == Model);
            if (obj != null)
            {
                int index = list.IndexOf(obj);
                list[index].Manufacturer = Manufacturer;
                list[index].Name = Name;
                list[index].Model = Model;
                list[index].Capacity = Capacity;
                list[index].Count = Count;

                if (list[index] is Flash)
                {
                    Flash flash = (Flash)list[index];
                    flash.USB_Speed = Add_Info;
                    list[index] = obj;
                }
                else if (list[index] is HDD)
                {
                    HDD hdd = (HDD)list[index];
                    hdd.Spindle_Speed = Add_Info;
                    list[index] = hdd;
                }
                else
                {
                    DVD dvd = (DVD)list[index];
                    dvd.Write_Speed = Add_Info;
                    list[index] = dvd;
                }
            }
            else
            {
                Console.WriteLine("Enter correct model.");
            }
        }

        public void Find(string Model)
        {
            Storage? obj = list.Find(e => e.Model == Model);
            if (obj != null)
            {
                obj.Print();
            }
            else
            {
                Console.WriteLine("Not found.");
            }
        }

        public void Save()
        {
            XMLSerialize s = new XMLSerialize();
            s.Save(list);
        }

        public void Load()
        {
            XMLSerialize s = new XMLSerialize();
            list = s.Load();
        }

        public void Print()
        {
            foreach (Storage storage in list)
            {
                storage.Print();
            }
        }
    }
}
