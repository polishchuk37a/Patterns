using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public class AdapterCarToCamel : ICarMove
    {
        private readonly Camel _camel;

        public AdapterCarToCamel(Camel camel)
        {
           this. _camel = camel;
        }

        public void CarMove()
        {
           this._camel.CamelMove();
        }
    }
}
