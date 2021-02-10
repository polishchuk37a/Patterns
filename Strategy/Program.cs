using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            var ork = new Ork();
            ork.SetStrategy(new StrategyWalk());
            ork.Move();

            Console.WriteLine();

            var troll = new Troll();
            troll.SetStrategy(new StrategyWalk());
            troll.Move();

            Console.WriteLine();

            var pegas = new Pegas();
            pegas.SetStrategy(new StrategyFlyAndWalk());
            pegas.Move();

            Console.WriteLine();
            
            var elf = new Elf();
            elf.SetStrategy(new StrategyMagic());
            elf.Move();

            Console.WriteLine();

            var vampire = new Vampire();
            vampire.SetStrategy(new StrategyFlyAndWalk());
            vampire.Move();

            Console.WriteLine();

            var harp = new Harp();
            harp.SetStrategy(new StrategyFlyAndWalk());
            harp.Move();

            Console.WriteLine();
        }
    }
}
