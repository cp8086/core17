using core17.Models;
using Microsoft.EntityFrameworkCore;

namespace core17
{
    public class MyContext:DbContext
    {
        public DbSet<Student> Students
        {
            get;
            set;

        }


        protected  void Onconfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("Server=192.168.2.94;Database=day;user id =sa;Password=Misszeng9;pooling=true; max pool size=512;");

            base.OnConfiguring(optionsBuilder);

        }



    }
}