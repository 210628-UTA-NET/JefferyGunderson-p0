using System;
using System.Collections.Generic;
using SAModels;


namespace SADL

{
    public interface IRepository
    {
        List<Customer> GetAllCustomers();

        Customer GetCustomer(Customer p_customer);

        Customer AddCustomer(Customer p_customer);
    }
}