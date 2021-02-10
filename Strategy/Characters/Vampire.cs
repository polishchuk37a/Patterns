using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class Vampire
    {
        private IMoveStrategy _strategyMove;

        public Vampire() { }

        public Vampire(IMoveStrategy strategyMove)
        {
            this._strategyMove = strategyMove;
        }

        public void SetStrategy(IMoveStrategy strategyMove)
        {
            this._strategyMove = strategyMove;
        }

        public void Move()
        {
            Console.Write("The Vampire");
            this._strategyMove.DoMove();
        }
    }
}
