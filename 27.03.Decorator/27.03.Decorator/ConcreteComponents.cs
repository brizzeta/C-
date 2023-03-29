using System;

namespace _27._03.Decorator
{
    internal class Elf : Component
    {
        public Elf() 
        {
            Attac = 15;
            Speed = 30;
            Health = 100;
            Protection = 0;
            Level = 1;
        }
        public override string ToString() => $"ELF\n\nAttac - {Attac}\nSpeed - {Speed}\nHealth - {Health}\nProtection - {Protection}";
    }
    internal class Human : Component
    {
        public Human()
        {
            Attac = 20;
            Speed = 20;
            Health = 150;
            Protection = 0;
        }
        //public override void NewLevel(Component hero)
        //{
        //    Console.Write("New level - ");
        //}
        //public void NewLevelChanges(BaseDecorator hero)
        //{
        //    Attac += hero.Attac;
        //    Speed += hero.Speed;
        //    Health += hero.Health;
        //    Protection += hero.Protection;
        //}
        public override string ToString() => $"ELF\n\nAttac - {Attac}\nSpeed - {Speed}\nHealth - {Health}\nProtection - {Protection}";
    }
}
