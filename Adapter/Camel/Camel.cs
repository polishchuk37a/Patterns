using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public class Camel : ICamelMove
    {
        public void CamelMove()
        {
            Console.WriteLine("The desert began. The traveler rides by camel");          
        }
    }
}
