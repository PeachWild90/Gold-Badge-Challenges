using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_6
{
    public enum CarType { Electric = 1, Hybrid = 2, Gas = 3}
    public class CarInfo
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int MilesPerGallon { get; set; }
        public bool IsItBadass { get; set; }
        public CarType CarType { get; set; }

        public CarInfo(string make, string model, int milesPerGallon, bool isItBadass, CarType carType)
        {
            Make = make;
            Model = model;
            MilesPerGallon = milesPerGallon;
            IsItBadass = isItBadass;
            CarType = carType;
        }

        public CarInfo()
        {

        }

    }
}
