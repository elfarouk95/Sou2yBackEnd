using System;
using Contracts;
using Entitis.Data;
using Entitis.Models;

namespace Repository
{
    public class RepositoryManager : IRepositoryManger
    {
        private RepositoryContext context;
        private ICustomerRepository customerRepository;

        public RepositoryManager(RepositoryContext _context)
        {
            context = _context;
        }


     


        public void Save()
        {
            context.SaveChanges();
        }

        ICustomerRepository IRepositoryManger.Customer()
        {
           
                if (customerRepository == null)
                {
                    customerRepository = new CustomerRepository(context);
                }
                return customerRepository;
            
        }
    }
}
