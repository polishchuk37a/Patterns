using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class StrategyFlyAndWalk : IMoveStrategy
    {
        public void DoMove()
        {
            Console.Write(" is flying and walking");
        }
    }
}
