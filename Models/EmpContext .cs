using Microsoft.EntityFrameworkCore;

namespace EmployeeManagement.Models
{
    public class EmpContext : DbContext
    {
        public EmpContext(DbContextOptions options) : base(options)
        {

        }
        DbSet<Employees> Employees { get; set; }
    }
}
