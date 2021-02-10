using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class Troll 
    {
        private IMoveStrategy _strategyMove;

        public Troll() { }

        public Troll(IMoveStrategy strategyMove)
        {
            this._strategyMove = strategyMove;
        }

        public void SetStrategy(IMoveStrategy strategyMove)
        {
            this._strategyMove = strategyMove;
        }

        public void Move()
        {
            Console.Write("The Troll");
            this._strategyMove.DoMove();
        }
    }
}
