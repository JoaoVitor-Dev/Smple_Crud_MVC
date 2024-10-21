using Microsoft.EntityFrameworkCore;

namespace Smple_Crud_MVC.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options):base(options)
        {
            
        }

        public DbSet<Produto> Produto { get; set; }
    }
}
