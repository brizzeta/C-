using System;

namespace _27._03.Decorator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Component obj = new Human();
            obj = new Archer(obj);
            Component obj2 = new Elf();
            obj2 = new Elf_Warrior(obj2);
            Console.WriteLine("Health -> " + obj.Health + " Attack -> " + obj.Attac + " Speed -> " + obj.Speed + " Level -> " + obj.Level);
            Console.WriteLine("Health -> " + obj2.Health + " Attack -> " + obj2.Attac + " Speed -> " + obj2.Speed + " Level -> " + obj2.Level);
        }
    }
}
