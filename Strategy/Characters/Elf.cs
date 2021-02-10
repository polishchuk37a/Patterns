using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class Elf
    {
        private IMoveStrategy _strategyMove;     

        public Elf() { }

        public Elf(IMoveStrategy strategyMove)
        {
            this._strategyMove = strategyMove;        
        }

        public void SetStrategy(IMoveStrategy strategyMove)
        {
            this._strategyMove = strategyMove;
        }
        public void Move()
        {
            Console.Write("The Elf");
            this._strategyMove.DoMove();        
        }
    }
}
