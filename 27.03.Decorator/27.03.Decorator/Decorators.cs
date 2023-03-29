using System;

namespace _27._03.Decorator
{
    internal abstract class BaseDecorator : Component
    {
        protected Component hero;

        public BaseDecorator(Component hero)
        {
            this.hero = hero;
        }
    }
    internal class Human_Warrior : BaseDecorator
    {
        public Human_Warrior(Component hero) : base(hero)
        {
            Attac = 20;
            Speed = 10;
            Health = 50;
            Protection = 20;
        }
    }
    internal class Swordsman : BaseDecorator
    {
        public Swordsman(Component hero) : base(hero) 
        {
            Attac = 40;
            Speed = -10;
            Health = 50;
            Protection = 40;
        }
    }
    internal class Archer : BaseDecorator
    {
        public Archer(Component hero) : base(hero)
        {
            Attac = 20;
            Speed = 20;
            Health = 50;
            Protection = 10;
        }
    }
    internal class Rider : BaseDecorator
    {
        public Rider(Component hero) : base(hero)
        {
            Attac = -10;
            Speed = 40;
            Health = 200;
            Protection = 100;
        }
    }
    internal class Elf_Warrior : BaseDecorator
    {
        public Elf_Warrior(Component hero) : base(hero)
        {
            Attac = 20;
            Speed = -10;
            Health = 100;
            Protection = 20;
        }
    }
    internal class Magician : BaseDecorator
    {
        public Magician(Component hero) : base(hero)
        {
            Attac = 10;
            Speed = 10;
            Health = -50;
            Protection = 10;
        }
    }
    internal class Crossbowman : BaseDecorator
    {
        public Crossbowman(Component hero) : base(hero)
        {
            Attac = 20;
            Speed = 10;
            Health = -50;
            Protection = 10;
        }
    }
    internal class EvilMage : BaseDecorator
    {
        public EvilMage(Component hero) : base(hero)
        {
            Attac = 70;
            Speed = 20;
            Health = 0;
            Protection = 0;
        }
    }
    internal class GoodMage : BaseDecorator
    {
        public GoodMage(Component hero) : base(hero)
        {
            Attac = 50;
            Speed = 30;
            Health = 100;
            Protection = 30;
        }
    }
}
