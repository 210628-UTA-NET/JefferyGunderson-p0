using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using SADL.Entities;

using SAModels;

namespace SADL
{

    public class Repository : IRepository
    {
        private Entities.GundContext _context;
        public Repository(Entities.GundContext p_context)
        {
            _context = p_context;
        }



        //Called within the BL from _rep, a repository field variable, takes in customer object
        public SAModels.Customer AddCustomer(SAModels.Customer p_customer)
        {
            _context.Customers.Add(new Entities.Customer
            {
                Id = p_customer.Id,
                CustomerName = p_customer.Name,
                CustomerAddress = p_customer.Address,
                CustomerEmail = p_customer.Email
            });
            _context.SaveChanges();
            return p_customer;
        }

        public List<SAModels.Customer> GetAllCustomers()
        {
            return _context.Customers.Select(
                cust =>
                    new SAModels.Customer()
                    {
                        Id = cust.Id,
                        Name = cust.CustomerName,
                        Address = cust.CustomerAddress,
                        Email = cust.CustomerEmail
                    }
            ).ToList();
        }

        public SAModels.Customer GetCustomer(SAModels.Customer p_customer)
        {
            throw new NotImplementedException();
        }
    }
}