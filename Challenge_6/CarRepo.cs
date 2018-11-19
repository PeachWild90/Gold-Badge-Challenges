using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_6
{
    class CarRepo
    {
        List<CarInfo> _listOfCarInfo = new List<CarInfo>();

        public void AddCarToList(CarInfo info)
        {
            _listOfCarInfo.Add(info);
        }

        public List<CarInfo> GetCarList()
        {
            return _listOfCarInfo;
        }

        public void RemoveCarInfo(CarInfo info)
        {
            _listOfCarInfo.Remove(info);
        }

        public void CarInfo()
        {

        }
    }
}
