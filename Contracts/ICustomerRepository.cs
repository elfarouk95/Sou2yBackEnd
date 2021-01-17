using System;
using System.Collections.Generic;
using Entitis.Models;

namespace Contracts
{
    public interface ICustomerRepository { 

        public void Login(Customer c );

        public IEnumerable<Customer> GetAllCustomers(bool TrackChanges);

        public void Register(Customer c);
        IEnumerable<Customer> GetAllCustomers();
    }
}
