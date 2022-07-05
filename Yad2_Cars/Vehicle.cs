using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yad2_Cars
{
    [Serializable]
    class Vehicle
    {
        public int _mileage { get; set; }
        public int _year { get; set; }
        public int _hand { get; set; }
        public string _model { get; set; }
        public int _price { get; set; }


        public Vehicle(int Mileage, int Year, string Model, int Price, int Hand = 2)
        {
            _mileage = Mileage;
            _year = Year;
            _hand = Hand;
            _model = Model;
            _price = Price;
        }
        public virtual string GiveInfo()
        {
            string info = "test";
            return info;
        }
    }
}