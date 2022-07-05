using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yad2_Cars
{
    [Serializable]
    class PetrolCar : Car
    {
        public bool _isTurbo { get; set; }

        public PetrolCar(bool IsTurbo, bool IsSedan, int NumSeats, int Mileage, int Year, string Model, int Price, int Hand = 2) : base(IsSedan, NumSeats, Mileage, Year, Model, Price, Hand)
        {
            _isTurbo = IsTurbo;
        }
        public override string GiveInfo()
        {
            string info;
            string turbo;
            string sedan;
            if (_isTurbo)
                turbo = "It has turbo";
            else
                turbo = "It has no turbo";
            if (_isSedan)
                sedan = "it's a sedan.";
            else
                sedan = "it's not a sedan.";

            info = $"This is a {_year} {_model} with {_mileage}KM, {_hand} hand with {_numSeats} seats in it. {turbo},and {sedan}.\nPrice:{_price}₪.";
            return info;
        }
    }
}