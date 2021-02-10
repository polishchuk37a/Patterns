using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public class Traveller
    {
        public void Move(ICarMove move)
        {
            move.CarMove();
        }
    }
}
