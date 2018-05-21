using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iibank.data
{
    public class FakeCustomerData
    {
        // Normally, this would be coming from a database
        public CustomerDataModel[] customers = new CustomerDataModel[]
        {
            new CustomerDataModel
            {
                CustomerId = 1,
                Name = "Bob Jones"
            },
            new CustomerDataModel
            {
                CustomerId= 2,
                Name = "Rick Smith"
            },
            new CustomerDataModel
            {
                CustomerId= 3,
                Name = "Jane Doe"
            }
        };
    }
}
