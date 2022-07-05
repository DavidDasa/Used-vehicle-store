using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yad2_Cars
{
    [Serializable]
    class MotorCycle : Vehicle
    {
        public int _topSpeed { get; set; }

        public MotorCycle(int TopSpeed, int Mileage, int Year, string Model, int Price, int Hand = 2) : base(Mileage, Year, Model, Price, Hand)
        {
            _topSpeed = TopSpeed;
        }
        public override string GiveInfo()
        {
            string info;
            info = $"This is a {_year} {_model}, it has {_mileage}KM ,it's {_hand} hand and a top speed of {_topSpeed}KM/H.\nPrice:{_price}₪";
            return info;
        }
    }
}