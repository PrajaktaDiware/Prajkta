using assignment6.Repository.Entity;
using assignment6.Repository.Infrastructure;
using assignment6.Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment6.Service
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository employeeRepository;
        private readonly IUnitOfWork unitOfWork;

        public EmployeeService(IEmployeeRepository employeeRepository, IUnitOfWork unitOfWork)
        {
            this.employeeRepository = employeeRepository;
            this.unitOfWork = unitOfWork;
        }

        public IEnumerable<Emp1> GetAllCustomers()
        {
            return employeeRepository.GetAll();
        }
    }

    public interface IEmployeeService
    {
        IEnumerable<Emp1> GetAllCustomers();
    }
}
