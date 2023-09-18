using Storage_dll;

namespace Serialize
{
    public interface ISerialize
    {
        void Save(List<Storage> list);
        List<Storage> Load();
    }
}