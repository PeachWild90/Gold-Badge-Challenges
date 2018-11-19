using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_3
{
    class OutingContent
    {
        public string OutingType { get; set; }
        public int NumOfPeople { get; set; }
        public string Date { get; set; }
        public Decimal TotalPerPerson { get; set; }
        public Decimal TotalForEvent { get; set; }

        public OutingContent(string outingType, int numOfPeople, string date, decimal totalPerPerson, decimal totalForEvent)
        {
            OutingType = outingType;
            NumOfPeople = numOfPeople;
            Date = date;
            TotalPerPerson = totalPerPerson;
            TotalForEvent = totalForEvent;
        }

        public OutingContent()
        {

        }
    }
}
