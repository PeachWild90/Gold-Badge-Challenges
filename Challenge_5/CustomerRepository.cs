using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_5
{
    class CustomerRepository
    {
        List<CustomerInfo> _listOfCustomerInfo = new List<CustomerInfo>();

        public void AddCutomerToList(CustomerInfo info)
        {
            _listOfCustomerInfo.Add(info); //passing in parameter ie info
            
        }

        public List<CustomerInfo> GetCustomerList()
        {
            return _listOfCustomerInfo;
        }

        public void RemoveCustomerInfo(CustomerInfo info)
        {
            _listOfCustomerInfo.Remove(info);
        }
        public CustomerRepository()
        {

        }
        public void SortList()
        {
          List<CustomerInfo> _sortedList =_listOfCustomerInfo.OrderBy(x => x.FirstName).ToList();

            _listOfCustomerInfo = _sortedList;
        }
    }
}
