using ComplexProject.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ComplexProject.Data
{
    public class ComplexContext : IdentityDbContext
    {
        IConfiguration config;
        public ComplexContext(IConfiguration _config)
        {
            config= _config;
        }

        public DbSet<Company> Company{ get; set; }
        public DbSet<Employee> Employee{ get; set; }
        public DbSet<Field> Field{ get; set; }
        public DbSet<ComplainSuggestion> ComplainSuggestion { get; set; }
        public DbSet<CoffeShop> CoffeShop { get; set; }
        public DbSet<GeneralServices> GeneralService { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(config.GetConnectionString("xyz"));
            //optionsBuilder.UseSqlServer("data source=localhost; initial catalog=ClinicDemoDb1112; integrated security=true");
            base.OnConfiguring(optionsBuilder);
        }



    }
}
