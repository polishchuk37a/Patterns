using System;

namespace Adapter
{          
    class Program
    {
        static void Main(string[] args)
        {
            Traveller traveller = new Traveller();

            Car car = new Car();

            Camel camel = new Camel();          
            ICarMove cammelMove = new AdapterCarToCamel(camel);

            traveller.Move(car);
            traveller.Move(cammelMove);      
        }
    }
}

