using assignment6.Repository.Entity;
using assignment6.Repository.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment6.Repository.Repository
{
    public class EmployeeRepository : RepositoryBase<Emp1>, IEmployeeRepository
    {
        public EmployeeRepository(IDatabaseFactory databaseFactory) : base(databaseFactory)
        {
        }
    }
    public interface IEmployeeRepository : IRepository<Emp1>
    {

    }
}
