using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class Ork
    {
        private IMoveStrategy _strategyMove;

        public Ork() { }       
        public Ork(IMoveStrategy strategyMove)
        {
            this._strategyMove = strategyMove;
        }

        public void SetStrategy(IMoveStrategy strategyMove)
        {
            this._strategyMove = strategyMove;
        }

        public void Move()
        {     
            Console.Write("The Ork");
            _strategyMove.DoMove();
        }
    }
}
