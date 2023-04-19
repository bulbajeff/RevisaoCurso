using Microsoft.EntityFrameworkCore;
using ProjetoUdemyAPI.Models;

namespace RevisaoAPI.Data
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }
        public DbSet<Evento> Eventos { get; set; }
    }
}