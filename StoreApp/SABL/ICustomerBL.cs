using System;
using System.Collections.Generic;

namespace SABL
{
    public interface ICustomerBL
    {
        List<Customer> GetAllCustomers();

        Customer AddCustomer(Customer p_customer);
    }
}