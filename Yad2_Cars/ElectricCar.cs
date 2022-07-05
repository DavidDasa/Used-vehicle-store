using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yad2_Cars
{
    [Serializable]
    class ElectricCar : Car
    {
        public int _range { get; set; }
        public double _chargeTime { get; set; }

        public ElectricCar(int Range, double ChargeTime, bool IsSedan, int NumSeats, int Mileage, int Year, string Model, int Price, int Hand = 2) : base(IsSedan, NumSeats, Mileage, Year, Model, Price, Hand)
        {
            _range = Range;
            _chargeTime = ChargeTime;
        }
        public override string GiveInfo()
        {
            string info;
            string sedan;
            if (_isSedan)
                sedan = "it's a sedan.";
            else
                sedan = "it's not a sedan.";

            info = $"This is a {_year} {_model}, it has {_mileage}KM ,it's {_hand} hand with {_numSeats} seats in it, and {sedan} " +
                $"Also it's capable of traveling {_range} with a single charge and a charging time of {_chargeTime} hours.\nPrice:{_price}₪";
            return info;
        }
    }
}