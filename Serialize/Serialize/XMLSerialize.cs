using System.Xml.Serialization;
using Storage_dll;

namespace Serialize
{
    public class XMLSerialize : ISerialize
    {
        XmlSerializer formatter = new XmlSerializer(typeof(List<Storage>), new[] { typeof(Storage) });
        public void Save(List<Storage> list)
        {
            // сохранение массива в файл
            using (FileStream fs = new FileStream("StorageList.xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, list);
            }
        }
        public List<Storage> Load()
        {
            // восстановление массива из файла
            using (FileStream fs = new FileStream("StorageList.xml", FileMode.OpenOrCreate))
            {
                List<Storage>? newstorage = formatter.Deserialize(fs) as List<Storage>;

                if (newstorage != null)
                {
                    return newstorage;
                }
                else
                {
                    return null;
                    Console.WriteLine("File is empty.");
                }
            }
        }
    }
}
