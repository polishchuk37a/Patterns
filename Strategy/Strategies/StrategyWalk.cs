using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class StrategyWalk : IMoveStrategy
    {
        public void DoMove()
        {
            Console.Write(" is walking");
        }
    }
}
