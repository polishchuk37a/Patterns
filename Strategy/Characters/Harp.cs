using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class Harp
    {
        private IMoveStrategy _strategyMove;

        public Harp() { }

        public Harp(IMoveStrategy strategyMove)
        {
            this._strategyMove = strategyMove;
        }

        public void SetStrategy(IMoveStrategy strategyMove)
        {
            this._strategyMove = strategyMove;
        }

        public void Move()
        {
            Console.Write("The Harp");
            this._strategyMove.DoMove();
        }
    }
}
