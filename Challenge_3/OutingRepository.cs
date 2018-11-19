using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_3
{
    class OutingRepository
    {
        List<OutingContent> _listOfOutings = new List<OutingContent>();

        public void AddOutingToList(OutingContent outing)
        {
            _listOfOutings.Add(outing);
        }

        public List<OutingContent> ShowAllOutings()
        {
            return _listOfOutings;
        }

        public OutingRepository()
        {

        }

        
    }
}
