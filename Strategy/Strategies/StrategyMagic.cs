using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class StrategyMagic : IMoveStrategy
    {
        public void DoMove()
        {
            Console.Write(" is flying by magic");
        }
    }
}
