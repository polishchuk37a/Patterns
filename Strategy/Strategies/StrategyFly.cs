using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class StrategyFly : IMoveStrategy
    {   
        public void DoMove()
        {
            Console.Write(" is flying");
        }  
    }
}
