using System;
using System.Collections.Generic;
using System.Linq;
using Contracts;
using Entitis.Data;
using Entitis.Models;

namespace Repository
{
    public class CustomerRepository : RepositoryBase<Customer>  , ICustomerRepository
    {
        public CustomerRepository(RepositoryContext  context): base(context)
        {
        }


        public IEnumerable<Customer> GetAllCustomers(bool TrackChanges)
        {
            //throw new NotImplementedException();

            return FindALl(TrackChanges).OrderBy(c => c.Fullname).ToList();

        }

        public IEnumerable<Customer> GetAllCustomers()
        {
            throw new NotImplementedException();
        }

        public void Login(Customer c)
        {
            throw new NotImplementedException();
        }

        public void Register(Customer c)
        {
            throw new NotImplementedException();
        }
    }
}
