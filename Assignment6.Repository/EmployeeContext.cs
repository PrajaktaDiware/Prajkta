using assignment6.Repository.Entity;
using Assignment6.Repository.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment6.Repository
{
    public class Employeecontext : DbContext
    {


        public Employeecontext() : base("name=MyConnection")
        {

        }
        public DbSet<Emp1> AEmployees { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<City> Cities { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public virtual void Commit()
        {
            base.SaveChanges();
        }
    }
}
