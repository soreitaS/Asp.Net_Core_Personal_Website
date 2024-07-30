using Microsoft.EntityFrameworkCore;
using Xore_ilk_Proje_Api.DAL.Entity;

namespace Core_ilk_Proje_Api.DAL.ApiContext
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-SBM90PD\\SQLEXPRESS;database=Core_ilk_ProjeDb2;integrated security=true");
        }
        public DbSet<Category> Categories { get; set; }
    }
}
