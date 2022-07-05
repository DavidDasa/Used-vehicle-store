using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yad2_Cars
{
    [Serializable]
    class Car : Vehicle
    {
        public bool _isSedan { get; set; }
        public int _numSeats { get; set; }

        public Car(bool IsSedan, int NumSeats, int Mileage, int Year, string Model, int Price, int Hand = 2) : base(Mileage, Year, Model, Price, Hand)
        {
            _isSedan = IsSedan;
            _numSeats = NumSeats;
        }
    }
}
