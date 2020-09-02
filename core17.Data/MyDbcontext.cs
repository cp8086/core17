using core17.Domain;
using Microsoft.EntityFrameworkCore;

namespace core17.Data
{
    public class MyDbcontext:DbContext
    {
        public MyDbcontext(DbContextOptions<MyDbcontext> options) : base(options)
        {




        }

        public DbSet<Person> Persons { get; set; }
        
    }
}
