using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using testMVCapp.Models;

namespace testMVCapp.Data
{
    public class CustomerContext:DbContext
    {
            public CustomerContext(DbContextOptions<CustomerContext> options)
                : base(options)
            {
            }
            public DbSet<Customer> Customers { get; set; }

    }
}
