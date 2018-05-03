using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternAbstractFactory
{
    
    public abstract class Unit
    {
        public string Name { get; private set; }
        public Unit(string name) => this.Name = name;
    }

    public abstract class Bowman : Unit
    {
        protected Bowman(string name) : base(name) { }
    }

    public abstract class Swordsman : Unit
    {
        protected Swordsman(string name) : base(name) { }
    }

    public abstract class Magicman : Unit
    {
        protected Magicman(string name) : base(name) { }
    }

    class FootBowman : Bowman
    {
        public FootBowman() : base("Foot Bowman") { }
    }
    class FootSwordsman : Swordsman
    {
        public FootSwordsman() : base("Foot Swordsman") { }
    }
    class FootMagicman : Magicman
    {
        public FootMagicman() : base("Foot Magicman") { }
    }

    class HorseBowman : Bowman
    {
        public HorseBowman() : base("Horse Bowman") { }
    }
    class HorseSwordsman : Swordsman
    {
        public HorseSwordsman() : base("Horse Swordsman") { }
    }
    class HorseMagicman : Magicman
    {
        public HorseMagicman() : base("Horse Magicman") { }
    }

    class DragonBowman : Bowman
    {
        public DragonBowman() : base("Dragon Bowman") { }
    }
    class DragonSwordsman : Swordsman
    {
        public DragonSwordsman() : base("Dragon Swordsman") { }
    }
    class DragonMagicman : Magicman
    {
        public DragonMagicman() : base("Dragon Magicman") { }
    }

    public interface IUnitFactory
    {
        Bowman GetBowman();
        Swordsman GetSwordsman();
        Magicman GetMagicman();
    }

    public class FootUnitFactory : IUnitFactory
    {
        public Bowman GetBowman()
        {
            return new FootBowman();
        }

        public Magicman GetMagicman()
        {
            return new FootMagicman();
        }

        public Swordsman GetSwordsman()
        {
           return new FootSwordsman();
        }
    }

    public class HorseUnitFactory : IUnitFactory
    {
        public Bowman GetBowman()
        {
            return new HorseBowman();
        }

        public Magicman GetMagicman()
        {
            return new HorseMagicman();
        }

        public Swordsman GetSwordsman()
        {
            return new HorseSwordsman();
        }
    }

    public class DragonUnitFactory : IUnitFactory
    {
        public Bowman GetBowman()
        {
            return new DragonBowman();
        }

        public Magicman GetMagicman()
        {
            return new DragonMagicman();
        }

        public Swordsman GetSwordsman()
        {
            return new DragonSwordsman();
        }
    }





    class Program
    {
        static void Main(string[] args)
        {
            IUnitFactory UnitFactory = new FootUnitFactory();

            Bowman bowman = UnitFactory.GetBowman();
            Swordsman swordsman = UnitFactory.GetSwordsman();
            Magicman magicman = UnitFactory.GetMagicman();

            Console.WriteLine($" I've got {bowman.Name}  and {swordsman.Name} and {magicman.Name}");

           UnitFactory = new  HorseUnitFactory();

            bowman = UnitFactory.GetBowman();
            swordsman = UnitFactory.GetSwordsman();
            magicman = UnitFactory.GetMagicman();

            Console.WriteLine($" I've got {bowman.Name}  and {swordsman.Name} and {magicman.Name}");

            UnitFactory = new DragonUnitFactory();

            bowman = UnitFactory.GetBowman();
            swordsman = UnitFactory.GetSwordsman();
            magicman = UnitFactory.GetMagicman();

            Console.WriteLine($" I've got {bowman.Name}  and {swordsman.Name} and {magicman.Name}");


        }
    }
}
