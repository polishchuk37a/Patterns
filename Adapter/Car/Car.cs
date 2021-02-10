using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public class Car : ICarMove
    {
        public void CarMove()
        {
            Console.WriteLine("The car is driving");
        }
    }
}
