using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ComplexProject.Models;

namespace ComplexProject.Data
{
    public class ComplexContext : IdentityDbContext
    {
        IConfiguration config;
        public ComplexContext(IConfiguration _config)
        {
            config= _config;
        }

        public DbSet<Company> Companies{ get; set; }
        public DbSet<Field> Fields{ get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(config.GetConnectionString("xyz"));
            //optionsBuilder.UseSqlServer("data source=localhost; initial catalog=ClinicDemoDb1112; integrated security=true");
            base.OnConfiguring(optionsBuilder);
        }



    }
}
