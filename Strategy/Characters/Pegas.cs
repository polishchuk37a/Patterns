using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class Pegas
    {
        private IMoveStrategy _strategyMove;

        public Pegas() { }

        public Pegas(IMoveStrategy strategyMove)
        {
            this._strategyMove = strategyMove;
        }

        public void SetStrategy(IMoveStrategy strategyMove)
        {
            this._strategyMove = strategyMove;
        }

        public void Move()
        {
            Console.Write("The Pegas");
            this._strategyMove.DoMove();
        }
    }
}
