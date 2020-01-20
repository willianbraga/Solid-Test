using System;

namespace SOLID.DIP.Contracts
{
    public class CustomerRepository :ICustomerRepository
    {
        public void Save(string name)
        {
            Console.WriteLine(name);
        }
    }
}