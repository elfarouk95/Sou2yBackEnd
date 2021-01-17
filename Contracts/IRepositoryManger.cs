using System;
namespace Contracts
{
    public interface IRepositoryManger
    {

        public ICustomerRepository Customer();

        public void Save();
    }
}
