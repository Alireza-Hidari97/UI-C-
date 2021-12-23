using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleApp
{
    class Bicycle : Vehicle
    {
        public const double INTEREST = 0.1;

        public int TireSize { get; set; }

        //Paved / Unpaved
        public string Terrain { get; set; }

        //constructor
        public Bicycle(string name,
            string brand, 
            double price, 
            int warranty, 
            string store,
            int tireSize,
            string terrain) :
            base(name, brand, price, warranty, store)
        {
            Terrain = terrain;
            TireSize = tireSize;
        }

        public override string Operate()
        {
            return "You need to pedal!";
        }

        //concrete implementation of CalculateInterest from Vehicle / ISellable
        //interest is 10% on bikes
        public override double CalculateInterest()
        {
            return base.Price * INTEREST;
        }
    }
}
