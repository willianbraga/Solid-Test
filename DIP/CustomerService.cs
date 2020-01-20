using SOLID.DIP.Contracts;

namespace SOLID.DIP
{
    public class CustomerService
    {
        private ICustomerRepository _repository;
        public CustomerService(ICustomerRepository repository)
        {
            _repository = repository;
        }
        public void Register(string name)
        {
            _repository.Save(name);
        }
    }
}