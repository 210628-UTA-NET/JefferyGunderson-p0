using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using SADL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using SAModels;

namespace SADL
{

    public class Repository : IRepository
    {
        private SADL.Entities.FirstDatabaseContext _context;
        public Repository(DLEntities.FirstDatabaseContext p_context)
        {
            _context = p_context;
        }



        //Called within the BL from _rep, a repository field variable, takes in customer object
        public Customer AddCustomer(Customer p_customer)
        {
            _context.Customers.Add(new SADL.Entities.Customer
            {
                Id = p_customer.Id,
                CustomerName = p_customer.Name,
                CustomerAddress = p_customer.Address,
                CustomerEmail = p_customer.Email
            });
            _context.SaveChanges();
            return p_customer;
        }

        public List<Customer> GetAllCustomers()
        {
            return _context.Customers.Select(
                cust =>
                    new Customer()
                    {
                        Id = cust.Id,
                        Name = cust.CustomerName,
                        Address = cust.CustomerAddress,
                        Email = cust.CustomerEmail
                    }
            ).ToList();
        }

        public Customer GetCustomer(Customer p_customer)
        {
            throw new NotImplementedException();
        }
    }
}