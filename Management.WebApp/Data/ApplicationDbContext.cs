using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Management.WebApp.Data
{
    //for user related table we use IdentityDbContext 
    public class ApplicationDbContext : IdentityDbContext<Employee>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        //Create a table model it as LeaveType and called it LeaveTypes
        public DbSet <LeaveType>LeaveTypes { get; set; }
        public DbSet <LeaveAllocation> LeaveAllocations { get; set; }

        
    }
}