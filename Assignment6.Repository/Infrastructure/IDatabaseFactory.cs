using System;

namespace assignment6.Repository.Infrastructure
{
    public interface IDatabaseFactory : IDisposable
    {
        Employeecontext Get();
    }
}